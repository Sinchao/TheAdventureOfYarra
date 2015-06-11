using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAdventuresOfYarra.Models;

namespace TheAdventuresOfYarra.Controllers
{
    class RosewaterDocksController
    {
        public TileSet CreateRosewaterDocks()
        {
            TileSet rosewaterDocks = new TileSet("Rosewater Docks");

            rosewaterDocks.tiles.Add(CreateDocks());
            rosewaterDocks.tiles.Add(CreateDockMasterHouse());

            return rosewaterDocks;
        }

        private Tile CreateDocks()
        {
            Tile Docks = new Tile("Docks");
            Docks.description = "The docks are really small. There's only place for two small boats or one large one to moor.";

            Docks.elements.Add(new Element("Sea", "The sea is rather calm here and the sound of the ripling water is rather sooting. What kind of mysteries are waiting to be found beyond the waves?"));
            Docks.elements.Add(new Element("Sun", "The sun reflex in the water turning it golden. What a pretty sight."));
            Docks.elements.Add(new Element("Dockmaster House", "The house of the Dockmaster is the biggest house on the island, yet it is surprisingly cute. It's overgrown by ivy and surrounded by flowers. It is two stories and looks out over the water. What a place to live!"));
            Docks.elements.Add(new Element("Lighthouse", "To your left is the lighthouse. It is very tall and striped red-and-white. The sight from the top must certainly be stunning!"));
            Docks.elements.Add(new Element("", ""));
            Docks.elements.Add(new Element("", ""));

            return Docks;

        }
        
        private Tile CreateDockMasterHouse()
        {
            Tile DockMasterHouse = new Tile("Dock Masters House");
            DockMasterHouse.description = "";

            DockMasterHouse.elements.Add(new Element("", ""));


            return DockMasterHouse;

        }
    }
}
