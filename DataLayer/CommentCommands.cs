using DataLayerDTO;
using DataLayerInterface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class CommentCommands : ICommentCommands, ICommentContainerCommands
    {
        private MySqlConnection conn = new MySqlConnection(DbConnect.connectionstring);
        private MySqlCommand command;
        private MySqlDataReader reader;
        public void AddComment(CommentDTO dto)
        {
            using(conn)
            {
                conn.Open();
                using(command = new MySqlCommand("INSERT INTO comment (Comment,UserId,TargetUserId) VALUES (@comment, @userid, @targetuserid)",conn))
                {
                    command.Parameters.AddWithValue("comment", dto.CommentText);
                    command.Parameters.AddWithValue("userid", dto.SourceUser);
                    command.Parameters.AddWithValue("targetuserid", dto.TargetUser);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteComment(int commentId)
        {
            using(conn)
            {
                conn.Open();
                using(command = new MySqlCommand("DELETE FROM comment WHERE CommentId = @commentid",conn))
                {
                    command.Parameters.AddWithValue("commentid", commentId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<CommentDTO> GetComments(int profileId)
        {
            using (conn)
            {
                conn.Open();
                using(command = new MySqlCommand("SELECT * FROM comment WHERE TargetUserId = @target",conn))
                {
                    command.Parameters.AddWithValue("target", profileId);
                    using(reader = command.ExecuteReader())
                    {
                        List<CommentDTO> dtos = new List<CommentDTO>();
                        while(reader.Read())
                        {
                            dtos.Add(new CommentDTO() { CommentId = reader.GetInt32(0), CommentText = reader.GetString(1), SourceUser = reader.GetInt32(2), TargetUser = reader.GetInt32(3), TimePosted = reader.GetDateTime(4) });
                        }
                        return dtos;
                    }
                }
            }
        }
    }
}
