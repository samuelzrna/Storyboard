using AutoMapper;
using StoryboardApp.Application.Stories.Commands;
using StoryboardApp.Application.Stories.Dto;
using StoryboardApp.Application.Tasks.Commands;
using StoryboardApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryboardApp.Application.Stories.MappingProfiles
{
    public class StoryMappingProfile : Profile
    {
        public StoryMappingProfile()
        {
            CreateMap<CreateStoryCommand, Story>();
            CreateMap<UpdateStoryCommand, Story>();
            CreateMap<Story, StoryDto>();
        }
    }
}
