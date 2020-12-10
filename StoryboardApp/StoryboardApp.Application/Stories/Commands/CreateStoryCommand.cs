using MediatR;
using StoryboardApp.Core.Enums;
using System;

namespace StoryboardApp.Application.Tasks.Commands
{
    public class CreateStoryCommand : IRequest<int>
    {
        public string Creator { get; set; }
        public string Title { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string Description { get; set; }
        public StoryState StoryState { get; set; }
        public DateTime DateCreated { get; set; }
    }
}