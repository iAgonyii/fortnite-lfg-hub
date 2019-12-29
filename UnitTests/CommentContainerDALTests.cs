using DataLayerInterface;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayerContainer;
using BusinessLayer;

namespace UnitTestData
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
    }
}
