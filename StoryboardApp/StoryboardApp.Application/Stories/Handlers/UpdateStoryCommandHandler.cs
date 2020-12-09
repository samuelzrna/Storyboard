using AutoMapper;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Application.Stories.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoryboardApp.Application.Stories.Handlers
{
    class UpdateStoryCommandHandler
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
            var result = await _unitOfWork.Stories.Update(_mapper.Map<StoryboardApp.Core.Entities.Story>(request));
            return result;
        }
    }
}
