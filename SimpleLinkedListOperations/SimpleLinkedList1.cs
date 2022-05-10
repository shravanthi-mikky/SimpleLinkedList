using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedListOperations
{
    public class SimpleLinkedList1<T>
    {
        public int count = 0;
        Node<T> head;
        public void AddNodeToLast(T Element)
        {
            Node<T> newNode = new Node<T>(Element);

            //2. assign data element
            newNode.data = Element;
            //3. assign null to the next of new node
            newNode.next = null;
            //4. Check the Linked List is empty or not,
            //   if empty make the new node as head
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //5. Else, traverse to the last node
                Node<T> temp = new Node<T>(Element);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;

                //6. Change the next of last node to new node
                temp.next = newNode;
            }
            count++;
        }

        public void display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write("->{0}", temp.data);
                temp = temp.next;
            }
        }
    }
}
