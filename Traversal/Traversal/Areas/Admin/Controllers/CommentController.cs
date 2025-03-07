using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CommentController : Controller
    {
        private readonly IAdminCommentService _commentService;

        public CommentController(IAdminCommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View(_commentService.TGetCommentListByDestination());
        }

        public IActionResult DeleteComment(int id)
        {
            _commentService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
