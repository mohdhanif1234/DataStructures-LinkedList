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
            //Inserting a node at beginning of the LL
            list.InsertNodeAtStart(80);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Appending a node in the last of a LL
            list.AppendNode(2);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Adding a new node 90 between two node 30 and 70
            list.AddNodeBetween(30, 70, 90);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Deletinng first node of the LinkedList
            list.DeleteFirstNode();
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Deleting last node of the LinkedList
            list.DeleteLastNode();
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Search a node in given LL
            list.SearchNode(3);
            //insert a node 15 after a given node 7 in LL
            list.InsertAfterNode(7, 15);
            list.displayLL();
            Console.WriteLine("\nEND OF APPLICATION\n****************************************************************");
            Console.ReadLine();
        }
    }
}
