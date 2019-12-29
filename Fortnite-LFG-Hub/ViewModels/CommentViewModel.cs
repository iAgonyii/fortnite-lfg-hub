using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.ViewModels
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public int SourceUser { get; set; }
        public int TargetUser { get; set; }
        public string CommentText { get; set; }
        public DateTime TimePosted { get; set; }

        public CommentViewModel()
        {

        }
    }
}
