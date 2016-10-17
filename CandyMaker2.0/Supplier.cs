using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMaker2._0
{
    class Supplier : SupplierChecker
    {
        //These are the supplies for the basis of the candy

        public string[] MaterialSupply = new string[5];
        public string[] TasteSupply = new string[5];
        public string[] ShapeSupply = new string[3] {"Square", "Round", "Triangular" }; //The shapes are pre-determined and stock

        //These are the supplies that hold the specific property of the different types of candy
        public string[] AromaSupply = new string[5];
        public string[] ColorSupply = new string[6];
        //We  declare an int of the Weight, because that's going to be a random number generated on the spot, not taken from a supply
        public int Weight;

        //Now we will create a method to enter all the reall important storages

        public void BaseMaterialSupplier()
        {
            Console.WriteLine("Hello! I am your supplier! Now what shall we deliver for you today?");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("You have " + (5 - i) + " slots for candy material left! What is your next material request?");
                MaterialSupply[i] = Console.ReadLine();
            }

            Console.WriteLine("Well that's that for the materials. Moving onto the most important part: the taste! What shall it be?");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("You have " + (5 - i) + " slots for candy tastes left! What is your next taste request?");
                TasteSupply[i] = Console.ReadLine();
            }

            Console.WriteLine("There are three types of candy we supply. The first are Bonbons - they're very aromatic!");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("You have " + (5 - i) + " slots for bonbon scents left! What is your next aroma request?");
                AromaSupply[i] = Console.ReadLine();
            }

            Console.WriteLine("The second type is Lollipops - they're very colorful so small children really love them.");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("You have " + (6 - i) + " slots for lollipop colors left! What is your next color request?");
                ColorSupply[i] = Console.ReadLine();
            }


        }
    }
}
