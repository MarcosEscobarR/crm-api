using Core.Models.Cases;
using FluentValidation;

namespace WebApi.Validations;

public class CasesValidator: AbstractValidator<CreateCaseModel>
{
    public CasesValidator()
    {
        RuleFor(p => p.ContactId).NotEmpty();
        RuleFor(p => p.CompanyId).NotEmpty();
        RuleFor(p => p.TypeId).NotEmpty();
        RuleFor(p => p.SubtypeId).NotEmpty();
        RuleFor(p => p.CompanyId).NotEmpty();
        RuleFor(p => p.TypificationId).NotEmpty();
        RuleFor(p => p.CaseOwnerId).NotEmpty();
        RuleFor(p => p.CaseStatusId).NotEmpty();
        
    }
}