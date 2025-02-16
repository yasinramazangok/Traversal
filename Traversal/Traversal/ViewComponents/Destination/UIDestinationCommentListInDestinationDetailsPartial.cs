using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class UIDestinationCommentListInDestinationDetailsPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        Context context = new Context();

        public UIDestinationCommentListInDestinationDetailsPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.DestinationId == id).Count();
            var values = _commentService.GetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
