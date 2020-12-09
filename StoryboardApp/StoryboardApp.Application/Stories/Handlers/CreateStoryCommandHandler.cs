using AutoMapper;
using MediatR;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Application.Tasks.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace TaskManagementApp.Application.Tasks.Handlers
{
    public class CreateStoryCommandHandler : IRequestHandler<CreateStoryCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateStoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Stories.Add(_mapper.Map<StoryboardApp.Core.Entities.Story>(request));
            return result;
        }
    }
}