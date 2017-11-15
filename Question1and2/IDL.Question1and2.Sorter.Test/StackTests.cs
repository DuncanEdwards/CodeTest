using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDL.Question1and2.Sorter.Test
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestEmpty()
        {
            var stack = new MyStack();

            Assert.AreEqual(null, stack.Peek());

        }

        [TestMethod]
        public void TestPushSingle()
        {
            var stack = new MyStack();

            stack.Push("duncan");

            Assert.AreEqual("duncan", stack.Peek());
        }

        [TestMethod]
        public void TestPushDouble()
        {
            var stack = new MyStack();

            stack.Push("duncan");
            stack.Push("edwards");

            Assert.AreEqual("edwards", stack.Peek());

        }

        [TestMethod]
        public void TestPeekSingle()
        {
            var stack = new MyStack();

            stack.Push("duncan");
            stack.Push("edwards");

            Assert.AreEqual("edwards", stack.Peek());

        }

        [TestMethod]
        public void TestPeekDouble()
        {
            var stack = new MyStack();

            stack.Push("duncan");
            stack.Push("edwards");

            stack.Peek();
            Assert.AreEqual("edwards", stack.Peek());

        }

        [TestMethod]
        public void TestPopSingle()
        {
            var stack = new MyStack();

            stack.Push("duncan");
            stack.Push("edwards");

            Assert.AreEqual("edwards", stack.Pop());
            Assert.AreEqual("duncan", stack.Pop());
            Assert.AreEqual(null, stack.Pop());

        }

        [TestMethod]
        public void TestPopDouble()
        {
            var stack = new MyStack();

            stack.Push("duncan");
            stack.Push("edwards");

            stack.Pop();
            Assert.AreEqual("duncan", stack.Pop());
            Assert.AreEqual(null, stack.Peek());

        }

        [TestMethod]
        public void TestClear()
        {
            var stack = new MyStack();

            stack.Push("duncan");
            stack.Push("edwards");

            stack.Clear();
            Assert.AreEqual(null, stack.Peek());

        }
    }
}
