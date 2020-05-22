using Microsoft.VisualStudio.TestTools.UnitTesting;
using Node;
using System;
using System.Collections.Generic;
using System.Text;

namespace Node.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void AddFirst_ShouldIncreaseCount()
        {
            // Arange
            LinkedList<int> list = new LinkedList<int>();

            // Act
            list.AddFirst(1);

            // Assert
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod()]
        public void AddFirst_ShouldAddCorrectElement()
        {
            // Arange
            LinkedList<int> list = new LinkedList<int>();

            // Act
            list.AddFirst(1);

            foreach (var item in list)
            {
                // Assert
                Assert.AreEqual(1, item);
            }

        }
    }
}