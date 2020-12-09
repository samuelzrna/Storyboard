using System;
using System.Collections.Generic;
using System.Text;
using StoryboardApp.Application.Interfaces;

namespace StoryboardApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IStoryRepository storyRepository)
        {
            Stories = storyRepository;
        }

        public IStoryRepository Stories { get; }
    }
}
