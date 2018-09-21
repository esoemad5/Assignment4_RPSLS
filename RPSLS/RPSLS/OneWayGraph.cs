using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class OneWayGraph <T>
    {
        public Node<T> head;
        private List<Node<T>> masterList;


        public OneWayGraph(Node<T> start)
        {
            head = start;
            masterList.Add(start);
        }
        public void addToGraph (Node<T> existingNode, Node<T> newNode) // existingNode beats newNode
        {
            masterList.Add(newNode);
            existingNode.addToNext(newNode);
        }



    }
}
