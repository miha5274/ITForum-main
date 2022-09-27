﻿using ITForum.Api.Models;
using ITForum.Application.Topics.Services.LikesAndDislikes;
using ITForum.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ITForum.Api.Controllers
{
    public class LikeController : BaseController
    {
        [HttpPut]
        public async Task<ActionResult> Like(UpdateMarkModel updateMarkModel)
        {
            await Mediator.Send(new LikeCommand
            { UserId = UserId, TopicId = updateMarkModel.TopicId, IsLiked = updateMarkModel.IsLiked });
            return NoContent();
        }
    }
}
