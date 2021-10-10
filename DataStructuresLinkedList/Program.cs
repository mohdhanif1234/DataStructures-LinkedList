using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Welcome to LinkedList implementation World!\n");
            Console.WriteLine("****************************************************************\n");
            LinkedList list = new LinkedList();
            list.AddNode(56);
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(9);
            list.AddNode(8);
            list.AddNode(7);
            list.AddNode(6);
            list.AddNode(3);
            list.AddNode(30);
            list.AddNode(70);
            Console.WriteLine("After adding some node in LL");
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Inserting a node at begning of the LL
            list.InsertNodeAtStart(80);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("\nEND OF APPLICATION\n****************************************************************");
            Console.ReadLine();
        }
    }
}
