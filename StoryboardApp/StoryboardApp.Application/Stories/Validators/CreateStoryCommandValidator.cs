using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using StoryboardApp.Application.Tasks.Commands;

namespace StoryboardApp.Application.Stories.Validators
{
    public class CreateStoryCommandValidator : AbstractValidator<CreateStoryCommand>
    {
        public CreateStoryCommandValidator()
        {
            
        }
    }
}
