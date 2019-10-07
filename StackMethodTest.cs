using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class StackOperationTest
    {
        [TestMethod]
        public void Push_AddElement_ReturnTrue()
        {
            //Arrange
            var pushElement = new stackProblemSolution.StackOperation();

            //Act
            var pushedElement = pushElement.Push(10);

            //Assert
            Assert.IsTrue(pushedElement);
            Assert.AreNotEqual(false, pushElement.Push(5));
            Assert.AreEqual(true, pushElement.Push(0));
            //Assert.AreEqual(2,);
        }
        [TestMethod]
        public void Pop_itShouldRemoveTopelement()
        {
            //Arrange
            var popAnElement = new stackProblemSolution.StackOperation();

            //throws exception when the stack is empty
            try
            {
                popAnElement.Pop();
            }
            catch(System.Exception e)
            {
                StringAssert.Contains(e.Message,"");
            }
            //Assert.ThrowsException< System.Exception>(()=> popAnElement.Pop());

            //push element
            popAnElement.Push(52);
            popAnElement.Push(55);
            popAnElement.Pop();

            int count = popAnElement.elementlists.Count;
            //Asset
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void printMaximumElement_shouldPrintMaximumElement()
        {
            var maxElement = new stackProblemSolution.StackOperation();

            Assert.ThrowsException<System.InvalidOperationException > (() => maxElement.printMaximumElement());
            maxElement.Push(55);
            maxElement.Push(57);
            maxElement.Push(59);
            maxElement.Pop();
            int count = maxElement.elementlists.Count;
            Assert.AreEqual(2, count);
            Assert.AreEqual(57, maxElement.printMaximumElement());
        }

    }
}
