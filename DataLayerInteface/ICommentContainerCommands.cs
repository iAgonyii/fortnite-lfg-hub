using DataLayerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerInterface
{
    interface ICommentContainerCommands
    {
        List<CommentDTO> GetComments(int profileId);
    }
}
