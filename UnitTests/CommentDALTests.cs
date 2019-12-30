using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestData
{
    [TestClass]
    public class CommentDALTests
    {
        private readonly CommentLogic logic = new CommentLogic();
        [TestMethod]
        public void AddComment()
        {
            bool added;
            try
            {
                logic.AddComment(66, 60, "Hello, this is a test comment");
                added = true;
            }
            catch(Exception)
            {
                added = false;
            }

            Assert.IsTrue(added);
        }

        [TestMethod]
        public void AddCommentOver1000CharsGivesError()
        {
            bool added;
            try
            {
                logic.AddComment(66, 62, "Hello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test commentHello, this is a test comment");
                added = true;
            }
            catch (Exception)
            {
                added = false;
            }

            Assert.IsFalse(added);
        }

        [TestMethod]
        public void DeleteComment()
        {
            bool deleted;
            try
            {
                logic.DeleteComment(22);
                deleted = true;
            }
            catch(Exception)
            {
                deleted = false;
            }

            Assert.IsTrue(deleted);
        }
    }
}
