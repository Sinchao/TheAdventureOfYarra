using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventuresOfYarra
{ 
    class TileManager 
    {
        List<List<Tile>> tileSets;

        public void Prepare() 
        {
            CreateTiles();
        }

        private void CreateTiles()
        {
            CreateRosewater();
        }

        private void CreateRosewater()
        {
            List<Tile> Rosewater = new List<Tile>();

            Tile livingDistrict = new Tile("livingDistrict");
        } 
    }
}