using AutoMapper;
using MediatR;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Application.Stories.Commands;
using StoryboardApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoryboardApp.Application.Stories.Handlers
{
    class UpdateStoryCommandHandler : IRequestHandler<UpdateStoryCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateStoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateStoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Stories.Update(_mapper.Map<Story>(request));
            return result;
        }
    }
}
