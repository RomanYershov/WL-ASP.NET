
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

        DiscussionRepository discussion;
      

        public ForumController()
        {
            discussion = new DiscussionRepository();
                      
        }
        public ActionResult Index()
        {
            var model =  ForumViewModel.GetModel();
            return View(model);
        }

        [HttpGet]
        public ActionResult Comments(int id)
        {
           // var comments = commentsService.GetCommentsByDiscussionId(id);//todo 
            return PartialView();
        }
    }
}