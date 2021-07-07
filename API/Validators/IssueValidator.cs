using Application.Commands;
using FluentValidation;

namespace API.Validators
{
    public class IssueValidator : AbstractValidator<CreateIssueCommand.Command>
    {
        public IssueValidator()
        {
            RuleFor(c => c.info).SetValidator(new IssueInfoValidator());
        }
    }
}