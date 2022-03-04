using AutoMapper;
using Core.Entities.Cases;
using Core.Models.Cases;

namespace WebApi.Mapping;

public class CasesProfile: Profile
{
    public CasesProfile()
    {
       CreateMap<CreateCaseModel, Case>();
    }
}