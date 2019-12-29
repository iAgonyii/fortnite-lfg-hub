using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataLayerDTO;
using DataLayerInterface;
using BusinessLayer;

namespace BusinessLayerContainer
{
    public class CommentsContainer
    {
        public List<Comment> comments;
        private readonly ICommentContainerCommands commentCommands = new CommentCommands();
        public List<Comment> GetComments(int profileid)
        {
            comments = new List<Comment>();
            foreach (CommentDTO dto in commentCommands.GetComments(profileid))
            {
                Comment comment = new Comment(dto);
                comments.Add(comment);
            }
            return comments;
        }
    }
}
