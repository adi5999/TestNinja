using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_Valid_AddIt()
        {
            var stack = new Stack<String>();
            stack.Push("a");
            Assert.That(() => stack.Count == 1);
        }
        [Test]
        public void Count_Empty_0()
        {
            var stack= new Stack();
            Assert.That(stack.Count == 0);
        }
        [Test]
        public void Pop_empty_Inva()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_Elements_Remove() {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Pop();

            Assert.That(stack.Count == 2);

        }
        [Test]
        public void Pop_Elements_Returmn() 
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var res = stack.Pop();
            Assert.That(res=="c" );
        }
        [Test]
        public void Peek_empty_null()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        public void Peak_ele_top()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var res=stack.Peek();

            Assert.That(res=="c");

        }


    }
}
