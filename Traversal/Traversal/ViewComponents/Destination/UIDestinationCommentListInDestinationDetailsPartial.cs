using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.ViewComponents.Comment
{
    public class UIDestinationCommentListInDestinationDetailsPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        TraversalContext context = new TraversalContext();

        public UIDestinationCommentListInDestinationDetailsPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.DestinationId == id).Count();
            return View(_commentService.TGetCommentListWithDestinationAndUser(id));
        }
    }
}
