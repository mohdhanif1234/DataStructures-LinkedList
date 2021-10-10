using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLinkedList
{
    class NodeCreation
    {
        public NodeCreation next;
        public int data;

        // constructor to create a node
        public NodeCreation(int value)
        {
            this.data = value;
        }
    }
}
