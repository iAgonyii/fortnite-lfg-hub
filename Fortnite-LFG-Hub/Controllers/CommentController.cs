using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Logic;
using Fortnite_LFG_Hub.Models;
using Fortnite_LFG_Hub.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fortnite_LFG_Hub.Controllers
{
    public class CommentController : Controller
    {
        [HttpPost]
        [Route("user/{id}/comment")]
        public IActionResult AddComment(int id, CommentViewModel comment)
        {
            if (ModelState.IsValid)
            {
                ProfileLogic logic = new ProfileLogic();
                // We can get the source profileId of the comment by getting the UserId saved in the session
                int sourceid = HttpContext.Session.Get<int>("UserId");
                logic.AddComment(sourceid, id, comment.CommentText);
                return RedirectToAction("Profile", "Profiles", id);
            }
            else
            {
                return View("Error", new Error() { errorMessage = "Comment input is required and can not be longer than 1000 characters." });
            }
        }


        [Route("user/{id}/comment/delete/{commentId}")]
        public IActionResult DeleteComment(int commentId, int id)
        {
            ProfileLogic logic = new ProfileLogic();
            logic.DeleteComment(commentId);
            return RedirectToAction("Profile", "Profiles", id);
        }
    }
}