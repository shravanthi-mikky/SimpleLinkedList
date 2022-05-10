﻿// See https://aka.ms/new-console-template for more information
using SimpleLinkedListOperations;

Console.WriteLine("Simple Linked List and Operations on it!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Creating Simple LinkedList\n2)Add Element at start\n3)Appending Elements to head\n4)Inserting the Element\n5)Removing the first Element");
    int option = Convert.ToInt16(Console.ReadLine());
    switch(option)
    {
        case 1:
            SimpleLinkedList1<int> obj1 = new();
            obj1.AddNodeToLast(56);
            obj1.AddNodeToLast(30);
            obj1.AddNodeToLast(70);
            int len=obj1.count;
            Console.WriteLine("Number of elements in the Simple Linked list are: {0}",len);
            obj1.display();
            Console.WriteLine("\n------------------------------------------");
            break;
        case 2:
            SimpleLinkedList1<int> obj2 = new();
            obj2.AddNodeToFront(70);
            obj2.AddNodeToFront(30);
            obj2.AddNodeToFront(56);
            int len1 = obj2.count;
            Console.WriteLine("Number of elements in the Simple Linked list are: {0}", len1);
            obj2.display();
            Console.WriteLine("\n------------------------------------------");
            break;
        case 3:
            SimpleLinkedList1<int> obj3 = new();
            obj3.head = new Node<int>(56);
            Node<int> newNode1 = new Node<int>(30);
            Node<int> newNode2 = new Node<int>(70);
            obj3.head.next=newNode1;
            newNode1.next = newNode2;
            newNode2.next = null;
            Console.WriteLine("The elements in LinkedList are:");
            obj3.display();
            Console.WriteLine("\n_________________________________________");
            break;
        case 4:
            SimpleLinkedList1<int> obj4 = new();
            obj4.AddNodeToFront(70);
            obj4.AddNodeToFront(56);
            obj4.InsertMethod(30, 2);
            Console.WriteLine("The elements in LinkedList are:");
            obj4.display();
            Console.WriteLine("\n_________________________________________");
            break;
        case 5:
            SimpleLinkedList1<int> obj5 = new();
            obj5.AddNodeToFront(70);
            obj5.AddNodeToFront(30);
            obj5.AddNodeToFront(56);
            Console.Write("The elements in LinkedList are:");
            obj5.display();
            int len5 = obj5.count;
            Console.WriteLine("\nNumber of elements in the Simple Linked list are: {0}", len5);
            obj5.Delete(56);
            Console.WriteLine("Number of elements after removing first element: {0}", obj5.count);
            Console.Write("The elements in LinkedList are:");
            obj5.display();
            Console.WriteLine("\n____________________________________________________");
            break;
        default:
            Console.WriteLine("Please choose correct option!");
            break;
    }
}