using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using StoryboardApp.Application.Tasks.Commands;
using StoryboardApp.Core.Enums;

namespace StoryboardApp.Application.Stories.Validators
{
    public class CreateStoryCommandValidator : AbstractValidator<CreateStoryCommand>
    {
        public CreateStoryCommandValidator()
        {
            RuleFor(t => t.Creator).NotEmpty();
            RuleFor(t => t.Title).NotEmpty();
            RuleFor(t => t.AcceptanceCriteria).NotEmpty();
            RuleFor(t => t.StoryState).NotEmpty();
            RuleFor(t => t.StoryState).IsInEnum();
            RuleFor(t => t.DateCreated).NotEmpty();
        }
    }
}
