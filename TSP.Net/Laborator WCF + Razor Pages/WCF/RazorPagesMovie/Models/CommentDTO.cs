using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public int PostPostId { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }

       
    }
}