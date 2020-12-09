
namespace StoryboardApp.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IStoryRepository Stories { get; }
    }
}
