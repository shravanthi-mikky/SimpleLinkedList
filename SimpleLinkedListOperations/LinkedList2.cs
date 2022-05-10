using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedListOperations
{
    public class LinkedList2
    {
        public Node1 head1;
        public int count = 0;
        public void AddNodeToFront(int data)
        {
            Node1 node = new Node1(data);
            node.next = head1;
            head1 = node;
            count++;
        }

        public void SearchElement(int searchValue)
        {
            Node1 temp = head1;
            int found = 0;
            int i = 0;
            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data == searchValue)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    Console.WriteLine(searchValue + " is found at index = " + i + ".");
                }
                else
                {
                    Console.WriteLine(searchValue + " is not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    }
}
