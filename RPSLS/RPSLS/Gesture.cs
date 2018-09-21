using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        private string data;
        private List<Gesture> next;

        public Gesture(string data)
        {
            this.data = data;
            next = new List<Gesture>();
        }

        public void AddToListOfThingsItBeats(Gesture nextNode)
        {
            this.next.Add(nextNode);
        }
        public string GetData() // function may not be needed because of Beats
        {
            return data;
        }

        public bool Beats(string gesture)
        {
            foreach (Gesture thingsItBeats in next)
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
