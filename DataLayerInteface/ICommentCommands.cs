using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    interface ICommentCommands
    {
        void AddComment(CommentDTO dto);
        void DeleteComment(int commentId);
    }
}
