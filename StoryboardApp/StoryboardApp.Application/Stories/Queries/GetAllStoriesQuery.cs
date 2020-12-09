using MediatR;
using StoryboardApp.Application.Stories.Dto;
using System.Collections.Generic;

namespace StoryboardApp.Application.Stories.Queries
{
    public class GetAllStoriesQuery : IRequest<List<StoryDto>>
    {
    }
}
