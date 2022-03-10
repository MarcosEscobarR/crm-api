using AutoMapper;
using Core.Entities.Cases;
using Core.Models.Cases;

namespace WebApi.Mapping;

public class CasesProfile: Profile
{
    public CasesProfile()
    {
       CreateMap<CreateCaseModel, Case>();
       CreateMap<Case, CasesListView>()
           .ForMember(dst => dst.TicketNumber, conf => conf.MapFrom(src => src.FinansysTicketNumber));
    }
}