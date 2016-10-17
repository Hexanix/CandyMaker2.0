using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace CandyMaker2._0
{
    class CandyBuilder : CandyAbstractData
    {
        public override string CandyType { get; set; }
        public override string CandyMaterial { get; set; }
        public override string CandyTaste { get; set; }
        public override string CandyShape { get; set; }
        public override string CandySpecificProperty { get; set; }


        private int CandyTypeIndex;
        Random RandomIndex = new Random();





        //Constructors that essentially make up the whole candy

        public CandyBuilder()
        {
           
        }

        public void Build(string[] MaterialSupplies, string[] TasteSupplies, string[] ShapeSupplies, string[] AromaSupplies, string[] ColorSupplies, int Weight)
        {
            CandyMaterial = MaterialSupplies[RandomIndex.Next(0, 4)];
            CandyTaste = TasteSupplies[RandomIndex.Next(0, 4)];
            CandyShape = ShapeSupplies[RandomIndex.Next(0, 2)];

            Console.WriteLine("Pick a candy type: 1 - Bonbon,  2 - Lollipop, 3 - Snack Bar");
            

            while (CandyTypeIndex != 1 && CandyTypeIndex != 2 && CandyTypeIndex != 3) //This is the major bug in the program. It skips the while when you give it a valid index.
            {
                CandyTypeIndex = int.Parse(Console.ReadLine());

                if (CandyTypeIndex == 1)
                {
                    candyAroma = AromaSupplies[RandomIndex.Next(0, 4)];
                    CandyType = "Bonbon";
                    CandySpecificProperty = " and smells of " + candyAroma;
                }
                else if (CandyTypeIndex == 2)
                {
                    candyColor = ColorSupplies[RandomIndex.Next(0, 5)];
                    CandyType = "Lollipop";
                    CandySpecificProperty = " and is the color of " + candyColor;
                }
                else if (CandyTypeIndex == 3)
                {
                    candyWeight = RandomIndex.Next(100, 800);
                    CandyType = "Snack bar";
                    CandySpecificProperty = " and weighs " + candyWeight + " grams.";
                }
                else
                {
                    Console.WriteLine("Not a valid index!");
                    CandyTypeIndex = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Building");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(200);


            Console.WriteLine("This is a " + CandyShape + " " + CandyType + " that is made out of " + CandyMaterial + " and tastes like " + CandyTaste + CandySpecificProperty);

        }


    }

}

       

        

       



       











    
    

