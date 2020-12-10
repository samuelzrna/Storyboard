using StoryboardApp.Core.Enums;
using System;

namespace StoryboardApp.Application.Stories.Dto
{
    public class StoryDto
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public string Title { get; set; }
        public string Assignee { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string Description { get; set; }
        public StoryState StoryState { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
