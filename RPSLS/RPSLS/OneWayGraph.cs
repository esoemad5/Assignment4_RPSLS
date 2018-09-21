using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class OneWayGraph <T>
    {
        Node<T> head;
        int size;
        List<Node<T>> masterList;


        public OneWayGraph(Node<T> start)
        {
            head = start;
            masterList.Add(start);
        }
        public void addToGraph (Node<T> existingNode, Node<T> newNode)
        {
            masterList.Add(newNode);
            existingNode.addToNext(newNode);
        }



    }
}
