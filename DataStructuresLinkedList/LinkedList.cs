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
            if (this.head == null)
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
        ///Method for Inserting a node at begning of the LL
        /// </summary>
        /// <param name="value"></param>
        public void InsertNodeAtStart(int value)
        {
            //Create a new Node of LL and add to LL
            NodeCreation node = new NodeCreation(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("After Inserting a node " + value + " at begning of the LL");
        }
        /// <summary>
        /// display the all node data in Current LL
        /// </summary>
        public void displayLL()
        {
            NodeCreation temp = head;
            if (temp == null)
            {
                Console.WriteLine("Given LL is empty");
            }
            Console.WriteLine("-->Display all node value of LL");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
