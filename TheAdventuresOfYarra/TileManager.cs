using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAdventuresOfYarra.Controllers;
using TheAdventuresOfYarra.Models;

namespace TheAdventuresOfYarra
{ 
    class TileManager 
    {
        List<TileSet> tileSets;

        public void Prepare() 
        {
            tileSets = new List<TileSet>();
            CreateTileSets();
        }

        private void CreateTileSets()
        {
            CreateRosewater();
            CreateRosewaterCave();
        }

        private void CreateRosewater()
        {
            RosewaterController controller = new RosewaterController();
            tileSets.Add(controller.CreateRosewater());
        } 

        private void CreateRosewaterCave()
        {
            RosewaterCaveController controller = new RosewaterCaveController();
            tileSets.Add(controller.CreateRosewaterCave());
        }

        private void CreateRosewaterDocks()
        {
            RosewaterDocksController controller = new RosewaterDocksController();
            tileSets.Add(controller.CreateRosewaterDocks());
        }
    }
}