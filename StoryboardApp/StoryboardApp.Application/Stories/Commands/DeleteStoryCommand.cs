using MediatR;

namespace StoryboardApp.Application.Stories.Commands
{
    public class DeleteStoryCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
