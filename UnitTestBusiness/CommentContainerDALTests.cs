using DataLayerInterface;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayerContainer;
using BusinessLayer;

namespace UnitTestContainer
{
    [TestClass]
    public class CommentContainerDALTests
    {
        private CommentsContainer commentsContainer = new CommentsContainer();
        [TestMethod]
        public void GetCommentsForId()
        {
            int id = 46;
            List<Comment> comments = commentsContainer.GetComments(id);

            Assert.AreEqual(comments.Count, 2);
        }

        [TestMethod]
        public void GetCommentForUnknownIdGivesEmptyList()
        {
            int id = 213213123;
            List<Comment> comments = commentsContainer.GetComments(id);

            Assert.AreEqual(comments.Count, 0);
        }
    }
}
