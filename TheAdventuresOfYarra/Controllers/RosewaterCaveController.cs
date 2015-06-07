using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAdventuresOfYarra.Models;

namespace TheAdventuresOfYarra.Controllers
{
    class RosewaterCaveController
    {
        public TileSet CreateRosewaterCave()
        {
            TileSet rosewaterCave = new TileSet("Rosewater Cave");

            rosewaterCave.tiles.Add(CreateCaveEntrance());

            return rosewaterCave;
        }

        private Tile CreateCaveEntrance()
        {
            //NYI

            return null;
        }


    }
}
