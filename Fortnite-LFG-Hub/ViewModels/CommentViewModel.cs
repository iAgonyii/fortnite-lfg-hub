using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fortnite_LFG_Hub.ViewModels
{
    public class CommentViewModel
    {
        [Required(ErrorMessage = "You can not post a comment without text")]
        [StringLength(1000, ErrorMessage = "Comments can not be longer than 1000 characters")]
        public string CommentText { get; set; }

        public CommentViewModel()
        {

        }
    }
}
