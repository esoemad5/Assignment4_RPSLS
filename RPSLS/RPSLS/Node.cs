using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Node
    {
        private string data;
        private List<Node> next;

        public Node(string data)
        {
            this.data = data;
        }

        public void AddToListOfThingsItBeats(Node nextNode) // This node beats nextNode(s)
        {
            this.next.Add(nextNode);
        }
        public string GetData() // function may not be needed because of Beats
        {
            return data;
        }

        public bool Beats(string gesture)
        {
            foreach (Node thingsItBeats in next)
            {
                if (data == thingsItBeats.data)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
