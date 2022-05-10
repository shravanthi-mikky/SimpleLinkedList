// See https://aka.ms/new-console-template for more information
using SimpleLinkedListOperations;

Console.WriteLine("Simple Linked List and Operations on it!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Creating Simple LinkedList\n2)Add Element at start\n3)Appending Elements to head");
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
        default:
            Console.WriteLine("Please choose correct option!");
            break;
    }
}