using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Node<T>
    {
        private T data;
        private List<Node<T>> next;

        public Node(T data)
        {
            this.data = data;
        }

        public void addToNext(Node<T> nextNode)
        {
            this.next.Add(nextNode);
        }
        public T getData()
        {
            return data;
        }



    }
}
