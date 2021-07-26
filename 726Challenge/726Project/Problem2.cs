using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _726Project
{
    public class Problem2
    {
        public LinkedList<object> StackList { get; set; }
        public Problem2()
        {
            StackList = new LinkedList<object>();
        }
        public void Push(object o)
        {
            StackList.AddLast(o);
        }
        public object Peek()
        {
            return StackList.Last;
        }
        public object Pop()
        {
            Object o = StackList.Last;
            StackList.RemoveLast();
            return o;
        }
    }
}
