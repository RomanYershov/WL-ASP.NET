
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WL.Models;
using WL.Services;

namespace WL.Controllers
{
    public class ForumController : Controller
    {

        DiscussionService discussion;
        CommentsService commentsService;

        public ForumController()
        {
            discussion = new DiscussionService();
            commentsService = new CommentsService();            
        }
        public ActionResult Index()
        {
            var model = discussion.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Comments(int id)
        {
            var comments = commentsService.GetCommentsByDiscussionId(id);//todo 
            return PartialView(comments);
        }
    }
}