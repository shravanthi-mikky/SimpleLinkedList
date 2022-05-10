using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLinkedListOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedListOperations.Tests
{
    [TestClass()]
    public class SimpleLinkedList1Tests
    {
        [TestMethod()]
        public void SearchElementTest()
        {
            SimpleLinkedList1<int> objt = new();
            objt.AddNodeToFront(70);
            objt.AddNodeToFront(30);
            objt.AddNodeToFront(56);
            objt.SearchElement(30);
            Assert.AreEqual(true, objt.SearchElement(30));
            
        }
    }
}