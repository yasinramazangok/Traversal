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
    public class CommentListInDestinationDetailsPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentListInDestinationDetailsPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetCommentByDestinationId(id);
            return View(values);
        }
    }
}
