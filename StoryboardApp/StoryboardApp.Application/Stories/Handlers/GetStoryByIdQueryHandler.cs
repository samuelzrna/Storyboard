using AutoMapper;
using MediatR;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Application.Stories.Dto;
using StoryboardApp.Application.Stories.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoryboardApp.Application.Stories.Handlers
{
    class GetStoryByIdQueryHandler : IRequestHandler<GetStoryByIdQuery, StoryDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStoryByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<StoryDto> Handle(GetStoryByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Stories.Get(request.Id);
            return _mapper.Map<StoryDto>(result);
        }
    }
}
