using DataLayerInterface;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayerDTO;

namespace BusinessLayer.Logic
{
    public class CommentLogic
    {
        private readonly ICommentCommands commentCommands = new CommentCommands();
        public void AddComment(int source, int target, string text)
        {
            CommentDTO dto = new CommentDTO() { SourceUser = source, TargetUser = target, CommentText = text };
            commentCommands.AddComment(dto);
        }
    }
}
