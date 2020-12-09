using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoryboardApp.Application.Stories.Commands;
using StoryboardApp.Application.Stories.Dto;
using StoryboardApp.Application.Stories.Queries;
using StoryboardApp.Application.Tasks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryboardApp.api.Controllers
{
    [Route("api/story")]
    [ApiController]
    public class StoryController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateStoryCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<StoryDto>>> GetAll() 
        {
            return await Mediator.Send(new GetAllStoriesQuery());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<StoryDto>> Get(int id)
        {
            return await Mediator.Send(new GetStoryByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateStoryCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteStoryCommand { Id = id });
        }
    }
}
