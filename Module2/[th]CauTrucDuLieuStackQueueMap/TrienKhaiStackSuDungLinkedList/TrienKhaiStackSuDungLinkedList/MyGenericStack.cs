using System;
using System.Collections.Generic;
using System.Text;

namespace TrienKhaiStackSuDungLinkedList
{
    class MyGenericStack
    {
        private LinkedList<Object> stack;

        public MyGenericStack()
        {
            stack = new LinkedList<Object>();
        }
        public int Size()
        {
            return stack.Count;
        }
        public bool IsEmpty()
        {
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Push(Object element)
        {
            stack.AddFirst(element);
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            stack.RemoveFirst();
        }


    }
}
