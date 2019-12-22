using DataLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    interface ICommentContainerCommands
    {
        List<CommentDTO> GetComments(int profileId);
    }
}
