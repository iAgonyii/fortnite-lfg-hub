using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    public interface ICommentContainerCommands
    {
        List<CommentDTO> GetComments(int profileId);
    }
}
