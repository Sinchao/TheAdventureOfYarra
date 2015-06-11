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
            rosewaterCave.tiles.Add(CreateCaveStairway());

            return rosewaterCave;
        }

        private Tile CreateCaveEntrance()
        {
            Tile CaveEntrance = new Tile("Cave Entrance");
            CaveEntrance.description = "Right in front of you is a tall rocky cliff. A lot of coal can be found in this area, so that's why they decided to start mining it.";

            CaveEntrance.elements.Add(new Element("Doors", "In the side of the cliff is a set of large wooden doors. Behind this is the carved stairway to the mine."));
            CaveEntrance.elements.Add(new Element("Sea", "To your right, to the east, is the sea, for as far as you can see. You can see the waves rolling around and you smell the salty scent. It is so majestic!"));
            CaveEntrance.elements.Add(new Element("Birds", "Flying from the sea is a flock of seagulls. They are heading for their nests in the sides of the looming cliffs."));
            CaveEntrance.elements.Add(new Element("Rabbit", "You hear a sudden rustling sound to your left. From between the tall grass appears a brown rabbit that hops out of sight. How cute!"));

            return CaveEntrance;
        }

        private Tile CreateCaveStairway()
        {
            Tile CaveStairway = new Tile("Cave Stairway");
            CaveStairway.description = "It is rather dark inside the mine. You're glad of the lamp that you brought, otherwise you wouldn't have seen anything!";

            CaveStairway.elements.Add(new Element("Steps", "The steps are rather steep and uneven. You'll need to be careful descending the stairs."));
           

            return CaveStairway;
        }
    }
}
