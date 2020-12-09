using FluentValidation;
using StoryboardApp.Application.Tasks.Commands;

namespace StoryboardApp.Application.Stories.Validators
{
    public class UpdateStoryCommandValidator : AbstractValidator<CreateStoryCommand>
    {
        public UpdateStoryCommandValidator()
        {
            RuleFor(t => t.Creator).NotEmpty();
            RuleFor(t => t.AcceptanceCriteria).NotEmpty();
            RuleFor(t => t.StoryState).NotEmpty();
            RuleFor(t => t.DateCreated).NotEmpty();
        }
    }
}
