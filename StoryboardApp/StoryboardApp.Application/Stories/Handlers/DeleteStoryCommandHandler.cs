using MediatR;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Application.Stories.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace StoryboardApp.Application.Stories.Handlers
{
    public class DeleteStoryCommandHandler : IRequestHandler<DeleteStoryCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(DeleteStoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Stories.Delete(request.Id);
            return result;
        }
    }
}
