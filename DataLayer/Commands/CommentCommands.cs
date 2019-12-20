using DataLayer.DTOs;
using DataLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Commands
{
    class CommentCommands : ICommentCommands, ICommentContainerCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;
        public void AddComment(CommentDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public List<CommentDTO> GetComments(int profileId)
        {
            throw new NotImplementedException();
        }
    }
}
