using Application.Commands;
using FluentValidation;

namespace API.Validators
{
    public class IssueInfoValidator : AbstractValidator<IssueInfo>
    {
        public IssueInfoValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .Length(5, 10);
            RuleFor(c => c.Description)
                .NotEmpty()
                .Length(5, 10);
        }
    }
}