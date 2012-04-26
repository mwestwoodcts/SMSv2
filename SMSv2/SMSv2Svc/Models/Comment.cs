using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSv2Svc.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AuthorName { get; set; }
    }
}