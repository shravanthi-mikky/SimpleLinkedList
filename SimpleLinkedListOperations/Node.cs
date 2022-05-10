using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedListOperations
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T Data)
        {
            this.data = Data;
        }
        
    }
    public class Node1
    {
        public int data;
        public Node1 next;
        public Node1(int Data)
        {
            this.data = Data;
        }

    }
}
