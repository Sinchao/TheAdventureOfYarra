using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventuresOfYarra
{
    //Beschrijft een element wat op een tile staat
    class Element
    {
        public string name;
        public string description;

        public Element(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
