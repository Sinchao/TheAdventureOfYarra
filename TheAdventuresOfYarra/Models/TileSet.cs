using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventuresOfYarra.Models
{
    class TileSet
    {
        public string name;
        public List<Tile> tiles;

        public TileSet(string name)
        {
            this.name = name;
            tiles = new List<Tile>();
        }

        public Tile Find(string name)
        {
            foreach (Tile t in tiles)
            {
                if(t.name == name)
                {
                    return t;
                }
            }

            return null;
        }
    }
}
