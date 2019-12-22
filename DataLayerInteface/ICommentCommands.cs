using DataLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface ICommentCommands
    {
        void AddComment(CommentDTO dto);
        void DeleteComment(int commentId);
    }
}
