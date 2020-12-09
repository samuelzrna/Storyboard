using AutoMapper;
using MediatR;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Application.Stories.Dto;
using StoryboardApp.Application.Stories.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StoryboardApp.Application.Stories.Handlers
{
    public class GetAllStoriesQueryHandler : IRequestHandler<GetAllStoriesQuery, List<StoryDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<StoryDto>> Handle(GetAllStoriesQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Stories.GetAll();
            return _mapper.Map<List<StoryDto>>(result.ToList());
        }
    }
}
