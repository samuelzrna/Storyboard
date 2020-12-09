using MediatR;
using StoryboardApp.Application.Stories.Dto;

namespace StoryboardApp.Application.Stories.Queries
{
    public class GetStoryByIdQuery : IRequest<StoryDto>
    {
        public int Id { get; set; }
    }
}
