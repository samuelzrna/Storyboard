using FluentValidation;
using StoryboardApp.Application.Stories.Commands;

namespace StoryboardApp.Application.Stories.Validators
{
    public class UpdateStoryCommandValidator : AbstractValidator<UpdateStoryCommand>
    {
        public UpdateStoryCommandValidator()
        {
            RuleFor(t => t.Id).NotEmpty();
        }
    }
}
