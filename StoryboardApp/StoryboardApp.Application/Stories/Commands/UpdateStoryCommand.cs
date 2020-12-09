using MediatR;
using StoryboardApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryboardApp.Application.Stories.Commands
{
    public class UpdateStoryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public string Assignee { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string Description { get; set; }
        public StoryState StoryState { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
