﻿using System;
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

            List<Tile> tileList = CreateTiles();
            rosewater.tiles = AddExits(tileList);

            return rosewater;
        }

        private List<Tile> CreateTiles()
        {
            List<Tile> tileList = new List<Tile>();

            tileList.Add(CreateHome());
            tileList.Add(CreateNeighbour());
            tileList.Add(CreateLivingDistrict());
            tileList.Add(CreateShoppingDistrict());
            tileList.Add(CreateGeneralStore());

            return tileList;
        }

        private List<Tile> AddExits(List<Tile> tileList)
        {
            tileList[0] = CreateHomeExits(tileList[0], tileList);
            tileList[1] = CreateNeighbourExits(tileList[1], tileList);
            tileList[2] = CreateLivingDistrictExits(tileList[2], tileList);
            tileList[3] = CreateShoppingDistrictExits(tileList[3], tileList);
            tileList[4] = CreateGeneralStoreExits(tileList[4], tileList);

            return tileList;
        }

        private Tile CreateHomeExits(Tile tile, List<Tile> tileList)
        {
            tile.exits.Add(new Exit(tileList[2], Direction.South));
            return tile;
        }

        private Tile CreateNeighbourExits(Tile tile, List<Tile> tileList)
        {
            tile.exits.Add(new Exit(tileList[2], Direction.East));
            return tile;
        }

        private Tile CreateLivingDistrictExits(Tile tile, List<Tile> tileList)
        {
            tile.exits.Add(new Exit(tileList[0], Direction.North));
            tile.exits.Add(new Exit(tileList[1], Direction.West));
            tile.exits.Add(new Exit(tileList[3], Direction.East));
            return tile;
        }

        private Tile CreateShoppingDistrictExits(Tile tile, List<Tile> tileList)
        {
            tile.exits.Add(new Exit(tileList[2], Direction.West));
            tile.exits.Add(new Exit(tileList[4], Direction.North));
            return tile;
        }

        private Tile CreateGeneralStoreExits(Tile tile, List<Tile> tileList)
        {
            tile.exits.Add(new Exit(tileList[3], Direction.South));
            return tile;
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
            shoppingDistrict.description = "The shopping district of Rosewater is slightly smaller than the living district.";

            shoppingDistrict.elements.Add(new Element("Tree", "A large chestnut tree grows near the entrance of the district. You remember how beautiful it is in fall."));
            shoppingDistrict.elements.Add(new Element("General Store", "In front of you is the general store, the largest building and the only one made out of stone. Here you can find whatever you like."));
            shoppingDistrict.elements.Add(new Element("Baker's", "Next to the general store is the baker's. They make delicious cinnamon rolls! They are sold out for the day and the shop is closed."));
            shoppingDistrict.elements.Add(new Element("Pond", "To your right is a small pond that is overgrown with waterlilies. A mother duck looks after her young."));
            shoppingDistrict.elements.Add(new Element("Bench", "In front of the pond is a little wooden bench, on which you often read books as a small child. Good times!"));

            return shoppingDistrict;
        }
        private Tile CreateGeneralStore()
        {
            Tile generalStore = new Tile("General Store");
            generalStore.description = "The general store is filled with curiousities. The owner lives on the first floor, but that is a private area.";

            generalStore.elements.Add(new Element("Owner", "The owner, Mr. Floote, greets you from behind the counter. He is a kind, rather thickset man."));
            generalStore.elements.Add(new Element("Shelves", "All around you are wooden shelves filled with the wares."));
            generalStore.elements.Add(new Element("Violin", "Your eyes fall on a beautiful violin. You've seen it before, and wanted to buy it if you ever save enough money. Perhaps one day."));
            generalStore.elements.Add(new Element("Fabric", "There's a bolt of green, patterned cotton. Mother said she wanted to make a new summer jacket. This colour would look lovely on her!"));
            generalStore.elements.Add(new Element("Candy", "You can smell the candy before you see it. There's a open jar with brightly coloured sweets. Hmm, perhaps buying a few won't hurt..."));

            return generalStore;
        }

    }
}
