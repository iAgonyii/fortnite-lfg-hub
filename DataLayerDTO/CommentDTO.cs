using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerDTO
{
    public struct CommentDTO
    {
        public int CommentId { get; set; }
        public int SourceUser { get; set; }
        public int TargetUser { get; set; }
        public string CommentText { get; set; }
        public DateTime TimePosted { get; set; }
    }
}
