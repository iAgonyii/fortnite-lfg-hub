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
                logic.AddComment(66, 57, "Hello, this is a test comment");
                added = true;
            }
            catch(Exception)
            {
                added = false;
            }

            Assert.IsTrue(added);
        }
    }
}
