using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities.Cases;
using Core.Interfaces.Repositories;
using Core.Models.Cases;
using Infraestructure.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories;

public class CasesRepository : ICasesRepository
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContextAccessor _dbContextAccessor;

    public CasesRepository(IMapper mapper, ApplicationDbContextAccessor dbContextAccessor)
    {
        _mapper = mapper;
        _dbContextAccessor = dbContextAccessor;
    }

    public async Task<List<CasesListView>> GetListView(int pageIndex, int pageSize)
    {
        return await _dbContextAccessor.Context.Cases
            .ProjectTo<CasesListView>(_mapper.ConfigurationProvider)
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<object> GetKanvanView(int pageIndex, int pageSize)
    {
        return await _dbContextAccessor.Context.Cases
            .GroupBy(p => p.CaseStatusId)
            .Select(p => new
            {
                header = p.Where(x => x.CaseStatusId == p.Key).Select(x => x.CaseStatus.Name).First(),
                value = p.Select(x => new KanvanDetail()
                {
                    Issue = x.Issue,
                    Resolver = x.Resolvers.Select(r => r.User.Name).ToList(),
                    Subtype = x.Subtype.Name,
                    Type = x.Type.Name,
                    TicketNumber = x.FinansysTicketNumber,
                    ResolutionAreas = x.CaseResolutionAreas.Select(area => area.ResolutionArea.Id.ToString()).ToList()
                })
            })
            .AsSplitQuery()
            .ToDictionaryAsync(p => p.header, arg => arg.value);
    }

    public Task<TResponseModel> GetCanvasView<TResponseModel>(int pageIndex, int pageSize)
    {
        throw new System.NotImplementedException();
    }

    public async Task<CaseModel?> GetCase(int id)
        => await _dbContextAccessor.Context.Cases
            .Where(p => p.Id == id)
            .ProjectTo<CaseModel>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
    

    public async Task Create(CreateCaseModel model, CancellationToken cancellationToken)
    {
        var @case = _mapper.Map<Case>(model);
        @case.Resolvers = model.ResolverIds.Select(r => new Resolver() {UserId = r}).ToList();
        @case.CaseResolutionAreas = model.ResolutionAreaIds.Select(r => new CaseResolutionArea() {ResolutionAreaId = r})
            .ToList();

        _dbContextAccessor.Context.Cases.Add(@case);
        await _dbContextAccessor.SaveChangesAsync(cancellationToken);
    }

    public Task Update<TRequestModel>(TRequestModel model, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}