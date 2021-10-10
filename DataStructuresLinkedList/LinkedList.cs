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
            Console.WriteLine("After Inserting a node " + value + " at beginning of the LL");
        }
        /// <summary>
        /// Appending a node in last node of LL
        /// </summary>
        /// <param name="value"></param>
        public void AppendNode(int appendValue)
        {
            //Create a new Node of LL and add to LL
            NodeCreation appendNode = new NodeCreation(appendValue);
            if (head == null)
            {
                this.head = appendNode;
            }
            else
            {
                NodeCreation temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = appendNode;
            }
            Console.WriteLine("\nAfter Appending node value " + appendValue + " at the end of LL");
        }

        // Adding a node between two nodes
        public void AddNodeBetween(int valueOne, int valueTwo, int value)
        {
            NodeCreation node = new NodeCreation(value);
            if (head == null || head.next == null)
            {
                Console.WriteLine("We can't add a node between two nodes");
                return;
            }
            else
            {
                NodeCreation temp = head;
                while (temp.next != null)
                {
                    if (valueOne.Equals(temp.data) && valueTwo.Equals(temp.next.data))
                    {
                        break;
                    }
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("\nAdding node " + value + " between two node " + valueOne + " and " + valueTwo + " of LL");
        }
        /// <summary>
        /// Delete a first node of the given LL
        /// </summary>
        public void DeleteFirstNode()
        {
            NodeCreation temp = this.head;
            if (head == null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            else
            {
                this.head = head.next;
                temp.next = null;
            }
            Console.WriteLine("\nAfter Deleting first node " + temp.data + " of LL");
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
