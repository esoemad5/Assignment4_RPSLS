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
        public string Data => data;
        private List<Gesture> thingsThisGestureBeats;

        public Gesture(string data)
        {
            this.data = data;
            thingsThisGestureBeats = new List<Gesture>();
        }

        public void AddToListOfThingsItBeats(Gesture nextNode)
        {
            thingsThisGestureBeats.Add(nextNode);
        }
        public string GetData() // function may not be needed because of Beats
        {
            return data;
        }

        public bool Beats(Gesture opponentsGesture)
        {
            foreach (Gesture gestureThisGestureBeats in thingsThisGestureBeats)
            {
                if (gestureThisGestureBeats.data == opponentsGesture.data )
                {
                    return true;
                }
            }
            return false;
        }



    }
}
