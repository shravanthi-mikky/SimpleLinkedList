using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedListOperations
{
    public class SimpleLinkedList1<T> where T : IComparable<T>
    {
        public int count = 0;
        public Node<T> head;
        public void AddNodeToFront(T data)
        {
            Node<T> node = new Node<T>(data);
            node.next = head;
            head = node;
            count++;
        }
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
        public void InsertMethod(T newElement, int position)
        {
            Node<T> newNode = new Node<T>(newElement);
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = new Node<T>(newElement);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }
        public int InsertAfter30(int searchValue, T newElement)
        {
            Node<T> temp = head;
            int found = 0;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data.Equals(searchValue))
                    {
                        found++;
                        Node<T> newNode = new Node<T>(newElement);
                        newNode.data = newElement;
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
            return found;
        }
        //deleting the top element
        public void Delete()
        {
            Node<T> tempnode = head;
            if (head != null)
            {
                tempnode = head;
                head = head.next;
                tempnode = null;
                count--;
            }        
        }
        //To Delete Last Node of LinkedList
        public void removeLastNode()
        {
            if (head == null)
                return;
            if (head.next == null)
            {
                return;
            }
            // Find the second last node
            Node<T> second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;
            // Change next of second last
            second_last.next = null;
        }
        public bool SearchElement(int searchValue)
        {
            Node<T> temp = head;
            int found = 0;
            int i = 0;
            bool status= false;
            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data.Equals(searchValue))
                    {
                        found++;
                        break;

                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    Console.WriteLine(searchValue + " is found at index = " + i + ".");
                    status= true;
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
            return status;
        }
        public void display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write("->{0}", temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
        // delete 40
        public int DeleteNode40(int searchValue)
        {
            Node<T> temp = head,previous=null;
            int found = 0;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data.Equals(searchValue))
                    {
                        found++;
                        previous.next = temp.next;
                        count--;
                        break;
                    }
                    previous = temp;
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
            return found;
        }
        public void sortedInsert(T data)
        {
            Node<T> current;
            Node<T> new_node = new Node<T>(data);

            /* Special case for head node */
            if (head == null || (head.data.CompareTo(new_node.data) >= 0))
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;

                while (current.next != null && (current.next.data.CompareTo(new_node.data)) < 0)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }
    }
}
