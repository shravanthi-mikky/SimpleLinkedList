// See https://aka.ms/new-console-template for more information
using SimpleLinkedListOperations;

Console.WriteLine("Simple Linked List and Operations on it!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Creating Simple LinkedList");
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
        default:
            Console.WriteLine("please choose correct option!");
            break;
    }
}