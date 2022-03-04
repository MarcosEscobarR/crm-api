using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities.Cases;
using Core.Helpers;
using Core.Interfaces.Repositories;
using Core.Models.Cases;
using Infraestructure.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories;

public class CasesRepository : ICasesRepository
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContextAccessor _dbContext;

    public CasesRepository(IMapper mapper, ApplicationDbContextAccessor dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<List<CasesListView>> GetListView(int pageIndex, int pageSize)
    {
        return await _dbContext.Context.Cases
            .Select(p => new CasesListView()
            {
                Id = new DatatableValue<int>("Id", p.Id),
                Comment = new DatatableValue<string>("Comentario", p.ClientComment),
                Description = new DatatableValue<string>("Descripcion", p.Description),
                Layout = new DatatableValue<string>("Layout", ""),
                Solution = new DatatableValue<string>("Solucion", p.Solution),
                Subject = new DatatableValue<string>("Subject", p.Subject),
                Promoter = new DatatableValue<string>("Promotor", $"{p.Promoter.FirstName} ${p.Promoter.LastName}"),
                ContactFullName =
                    new DatatableValue<string>("Contacto", $"{p.Contact.FirstName} ${p.Contact.LastName}"),
                CaseStatusName = new DatatableValue<string>("Estado", p.CaseStatus.Name),
                CaseOwnerName = new DatatableValue<string>("Case Owner", p.CaseOwner.User.Name),
                UpdatedAt = new DatatableValue<string>("Actualizado", p.UpdatedAt.ToString()),
                TypificationName = new DatatableValue<string>("Tipificacion", p.Typification.Name),
                TypeName = new DatatableValue<string>("Tipo", p.Type.Name),
                TicketNumber = new DatatableValue<string>("Numero de Ticket", p.FinansysTicketNumber),
                SubtypeName = new DatatableValue<string>("Subtipo", p.Subtype.Name),
                ResolverAreas = new DatatableValue<string>("Areas Resolutoras",
                    p.CaseResolutionAreas.Select(r => r.ResolutionArea.Id).FirstOrDefault().ToString()),
                RequestExtension = new DatatableValue<string>("Pedido de Extension", p.RequestExtension ? "Si" : "No"),
                ReceptionTime = new DatatableValue<string>("Timpo de Recepcion", p.Time.ToString("d")),
                ReceptionBranch = new DatatableValue<string>("Sucursal", ""),
                OriginName = new DatatableValue<string>("Origen", p.Origin.Name),
                CreatedAt = new DatatableValue<string>("Creado el", p.CreatedAt.ToString("d")),
                ContactPhone = new DatatableValue<string>("Telefono", p.Contact.Phone),
                ContactName = new DatatableValue<string>("Nombre", $"{p.Contact.FirstName} ${p.Contact.LastName}"),
                ContactEmail = new DatatableValue<string>("Email", p.Contact.Email),
                CompanyName = new DatatableValue<string>("Empresa", p.Company.Name),
                ClientNumber = new DatatableValue<string>("Numero de Cliente", ""),
                ClientBranch = new DatatableValue<string>("Sucursal Cliente", p.Contact.Branch.Id.ToString()),
                CallDirection = new DatatableValue<string>("Direccion de Llamada", ""),
                BusinessOfficer = new DatatableValue<string>("Oficial de Negocio", p.BusinessOfficer),
                BranchAffected = new DatatableValue<string>("Sucursales Afectadas", ""),
                NumberOfComments = new DatatableValue<int>("Numero de Comentarios", 0),
                Tags = new DatatableValue<List<string>>("Tags", new List<string>() {""}),
            })
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .AsSplitQuery()
            .ToListAsync();
    }

    public Task<TResponseModel> GetKanbanView<TResponseModel>(int pageIndex, int pageSize)
        where TResponseModel : CasesListView
    {
        throw new System.NotImplementedException();
    }

    public Task<TResponseModel> GetCanvasView<TResponseModel>(int pageIndex, int pageSize)
    {
        throw new System.NotImplementedException();
    }

    public async Task<CaseModel> GetCase(int id)
    {
        return await _dbContext.Context.Cases
            .Where(p => p.Id == id)
            .ProjectTo<CaseModel>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
    }

    public async Task Create(CreateCaseModel model, CancellationToken cancellationToken)
    {
        var @case = _mapper.Map<Case>(model);
        @case.Resolvers = model.ResolverIds.Select(r => new Resolver() {UserId = r}).ToList();
        @case.CaseResolutionAreas = model.ResolutionAreaIds.Select(r => new CaseResolutionArea() {ResolutionAreaId = r})
            .ToList();

        _dbContext.Context.Cases.Add(@case);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public Task Update<TRequestModel>(TRequestModel model, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}