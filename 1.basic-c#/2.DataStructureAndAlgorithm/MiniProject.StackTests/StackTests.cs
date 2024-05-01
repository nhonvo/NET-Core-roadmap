using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniProject.Stack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Stack.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void PushTest()
        {
            StackProject<int> stack = new StackProject<int>(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int result1 = stack.Pop();
            int result2 = stack.Pop();
            int result3 = stack.Pop();

            Assert.Equal(3, result1);
            Assert.Equal(2, result2);
            Assert.Equal(1, result3);

        }
        [TestMethod()]
        public void PushEmptyStackThrowEx()
        {
            StackProject<int> stack = new StackProject<int>(2);
            stack.Push(1);
            stack.Push(2);
            try
            {
                stack.Push(3);
            }
            catch (Exception ex)
            {
                StringAssert.Equals(ex.Message, "Can not push");
            }
        }
        [TestMethod()]
        public void PopTest()
        {
            StackProject<int> stack = new StackProject<int>(5);

            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            int result1 = stack.Pop();
            int result2 = stack.Pop();
            stack.Push(8);
            int result3 = stack.Pop();
            int result4 = stack.Pop();
            int result5 = stack.Pop();

            Assert.Equal(7, result1);
            Assert.Equal(6, result2);
            Assert.Equal(8, result3);
            Assert.Equal(5, result4);
            Assert.Equal(4, result5);
        }
        [TestMethod()]
        public void PopEmptyStackThrowEx()
        {
            StackProject<int> stack = new StackProject<int>(0);
            try
            {
                stack.Pop();
            }
            catch (Exception ex)
            {
                StringAssert.Equals(ex.Message, "Cannot pop item from an empty stack.");
            }
        }
        [TestMethod()]
        public void PeekTest()
        {
            StackProject<int> stack = new StackProject<int>(2);
            int result = 2;

            stack.Push(1);
            stack.Push(2);

            int topElement = stack.Peek();
            Assert.Equal(result, topElement);
        }
        [TestMethod()]
        public void PeekEmptyStackThrowEx()
        {
            StackProject<int> stack = new StackProject<int>(0);
            try
            {
                stack.Peek();
            }
            catch (Exception ex)
            {
                StringAssert.Equals(ex.Message, "Cannot peek at an empty stack.");
            }
        }

        [TestMethod()]
        public void CountTest()
        {
            StackProject<int> stack = new StackProject<int>(2);
            int result = 2;

            stack.Push(1);
            stack.Push(2);

            int count = stack.Count();
            Assert.Equal(result, count);
        }

        [TestMethod()]
        public void ClearTest()
        {
            StackProject<int> stack = new StackProject<int>(2);

            stack.Push(1);
            stack.Push(2);
            stack.Clear();
            int count = stack.Count();
            Assert.Equal(0, count);
        }
        [Fact]
        public void ClearEmptyStack()
        {
            StackProject<int> stack = new StackProject<int>(0);
            int result = 0;
            stack.Clear();

            int count = stack.Count();

            Assert.Equal(result, stack.Count);
        }
    }
}