using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLinkedList
{
    class LinkedList
    {   
        //initialize the head of the LL
        
        public NodeCreation head;
        /// <summary>
        /// add new node to LL in last
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            //Create a new Node of LL and add to LL
            NodeCreation node = new NodeCreation(value);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                NodeCreation temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        /// <summary>
        /// display the all node data in Current LL
        /// </summary>
        public void displayLL()
        {
            NodeCreation temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Given LL is empty");
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Display all node value of LL");
            Console.WriteLine("****************************************************************");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
