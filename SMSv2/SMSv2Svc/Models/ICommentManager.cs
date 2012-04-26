using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSv2Svc.Models
{
    public interface ICommentManager
    {
        Comment Create(Comment item);
        List<int> CreateComments(List<Comment> items);
        Comment Update(Comment item);
        Comment GetById(int id);
        List<Comment> GetComments(int? page, int? count);
        bool Delete(int id);
    }
}