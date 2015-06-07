using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventuresOfYarra.Models
{
    class Tile
    {
        public string name;
        public string description;
        public List<Element> elements;
        public List<Exit> exits;
        public TileSet tileSet;

        public Tile(string name)
        {
            //Zet de lijsten klaar voor gebruik
            this.name = name;
            elements = new List<Element>();
            exits = new List<Exit>();
        }

        public void Describe()
        {
            //Checkt voor Elementen in elements, en zet deze gelijk aan e
            //Voert hierna de code uit met e
            foreach(Element e in elements)
            {
                Console.WriteLine(e.description);
            }
        }

        public Tile returnThisTile()
        {
            return this;
        }
    }
}
