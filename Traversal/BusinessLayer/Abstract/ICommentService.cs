﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> GetCommentByDestinationId(int id);

        List<Comment> GetListCommentByDestination();

        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
