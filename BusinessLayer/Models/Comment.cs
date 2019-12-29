using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int SourceUser { get; set; }
        public int TargetUser { get; set; }
        public string CommentText { get; set; }
        public DateTime TimePosted { get; set; }

        public Comment(CommentDTO dto)
        {
            this.CommentId = dto.CommentId;
            this.SourceUser = dto.SourceUser;
            this.TargetUser = dto.TargetUser;
            this.CommentText = dto.CommentText;
            this.TimePosted = dto.TimePosted;
        }
    }
}
