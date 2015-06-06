using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventuresOfYarra
{
    class Tile
    {
        public string name;
        public List<Element> elements;
        public List<Tile> exits;
        public List<Tile> tileSet;

        public Tile(string name)
        {
            //Zet de lijsten klaar voor gebruik
            elements = new List<Element>();
            exits = new List<Tile>();
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
