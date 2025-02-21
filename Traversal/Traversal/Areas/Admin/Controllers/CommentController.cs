using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.GetListCommentByDestination();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.GetById(id);
            _commentService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
