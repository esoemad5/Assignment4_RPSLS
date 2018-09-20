using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Node<T>
    {
        public T data;
        public List<Node<T>> next;

        public Node(T data)
        {
            this.data = data;
        }




    }
}
