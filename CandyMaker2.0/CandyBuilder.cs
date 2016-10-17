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



        private int CandyTypeIndex;
        private string CandySpecificProperty;
        private string Shape;
        Random RandomIndex = new Random();





        //Constructors that essentially make up the whole candy

        public CandyBuilder(string[] MaterialSupplies, string[] TasteSupplies, string[] ShapeSupplies, string[] AromaSupplies, string[] ColorSupplies, int Weight)
        {
            CandyMaterial = MaterialSupplies[RandomIndex.Next(0, 4)];
            CandyTaste = TasteSupplies[RandomIndex.Next(0, 4)];
            CandyShape = ShapeSupplies[RandomIndex.Next(0, 2)];

            Console.WriteLine("Pick a candy type: 1 - Bonbon,  2 - Lollipop, 3 - Snack Bar");
            CandyTypeIndex = int.Parse(Console.ReadLine());

            while (CandyTypeIndex != 1 && CandyTypeIndex != 2 && CandyTypeIndex != 3)
            {
                if (CandyTypeIndex == 1)
                {
                    candyAroma = AromaSupplies[RandomIndex.Next(0, 4)];
                    CandyType = "bonbon";
                    CandySpecificProperty = " and smells of " + candyAroma;
                }
                else if (CandyTypeIndex == 2)
                {
                    candyColor = ColorSupplies[RandomIndex.Next(0, 5)];
                    CandyType = "lollipop";
                    CandySpecificProperty = " and is the color of " + candyColor;
                }
                else if (CandyTypeIndex == 3)
                {
                    Weight = RandomIndex.Next(100, 800);
                    CandyType = "shack bar";
                    CandySpecificProperty = " and weighs " + candyWeight;
                }
                else
                {
                    Console.WriteLine("Not a valid index!");
                }
            }
        }

        public void Build()
        {
            Console.WriteLine("Building");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);


            Console.WriteLine("This is a " + CandyShape + " " + CandyType + " that is made out of " + CandyMaterial + " and tastes like " + CandyTaste + CandySpecificProperty);

        }


    }

}

       

        

       



       











    
    

