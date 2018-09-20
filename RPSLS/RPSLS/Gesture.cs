using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Gesture
    {
        string name;
        List<string> winsAgainst;
        List<string> defeatedBy;

        public Gesture(string name)
        {
            this.name = name;
            //How to add wins/defeated from just a string?
        }
    }
}
