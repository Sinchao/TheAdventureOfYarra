using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAdventuresOfYarra.Models;

namespace TheAdventuresOfYarra.Controllers
{
    class RosewaterController
    {
        public TileSet CreateRosewater()
        {
            TileSet rosewater = new TileSet("Rosewater");

            rosewater.tiles.Add(CreateHome());
            rosewater.tiles.Add(CreateNeighbour());
            rosewater.tiles.Add(CreateLivingDistrict());
            rosewater.tiles.Add(CreateShoppingDistrict());
            rosewater.tiles.Add(CreateGeneralStore());

            return rosewater;
        }

        private Tile CreateHome()
        {
            Tile home = new Tile("Home");
            home.description = "This is your house. It's familiar smells make you feel right at home.";

            home.elements.Add(new Element("Bed", "There's a bed in the corner of the room. It is single, covered in a red, knitted quilt."));
            home.elements.Add(new Element("Cabinet", "In the opposite corner is a wooden cabinet, filled with books."));
            home.elements.Add(new Element("Rug", "On the floor in the middle of the room is big, fluffy rug. It's made of brightly coloured fabrics."));
            home.elements.Add(new Element("Door", "Behind you is the door. It has four small, square windows."));

            return home;
        }
        private Tile CreateNeighbour()
        {
            Tile neighbour = new Tile("Neighbour");
            neighbour.description = "Your neighbours house is slightly larger than your own. The orchard business must be nice!";

            neighbour.elements.Add(new Element("Couch", "Opposite to the door is a big, leather couch. It looks comfortable."));
            neighbour.elements.Add(new Element("Dinner table", "There is a square dinner table. It is surrounded by four chairs."));
            neighbour.elements.Add(new Element("Pie", "On top of the table is a pie. You smell apple and cinnamon."));
            neighbour.elements.Add(new Element("Cabinet", "Next to the table is cabinet with silverware. Shiny!"));

            return neighbour;
        }
        private Tile CreateLivingDistrict()
        {
            Tile livingDistrict = new Tile("Living District");
            livingDistrict.description = "This is the living district of Rosewater. A rather pompous name for a place with only two houses!";

            livingDistrict.elements.Add(new Element("Home", "You can see your home! It's tiny windows give you a comfortable feeling."));
            livingDistrict.elements.Add(new Element("Rosebushes", "There's rosebushed in front of your house. The wind carries their scent everywhere!"));
            livingDistrict.elements.Add(new Element("Neighbour", "There's lights on in your neighbours house. Someone must be home!"));
            livingDistrict.elements.Add(new Element("Orchard", "You can just make out the apple orchard behind the neighbours house."));
            livingDistrict.elements.Add(new Element("Path", "There's a cobblestone path connecting the houses, and leading out to the shopping district."));

            return livingDistrict;
        }
        private Tile CreateShoppingDistrict()
        {
            Tile shoppingDistrict = new Tile("Shopping District");
            shoppingDistrict.description = "";

            shoppingDistrict.elements.Add(new Element("", ""));

            return shoppingDistrict;
        }
        private Tile CreateGeneralStore()
        {
            Tile generalStore = new Tile("General Store");
            generalStore.description = "";

            generalStore.elements.Add(new Element("", ""));

            return generalStore;
        }

    }
}
