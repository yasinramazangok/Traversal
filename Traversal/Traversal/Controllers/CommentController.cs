using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            // ViewBag.destID = id;
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = 5;
            // ViewBag.a = "merhaba";
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.Status = true;
            _commentService.Insert(comment);
            return RedirectToAction("Home", "Destination");
        }
    }
}
