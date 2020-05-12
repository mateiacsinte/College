using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class PostDTO
    {
        public PostDTO() { }
        public int PostId { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public DateTime Date { get; set; }

        public List<CommentDTO> Comments;
    }
}