using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CandyMaker2._0
{
    class Program : Supplier
    {
        static void Main(string[] args)
        {
            //First you must supply your candy storage!
            Supplier supplier = new Supplier();
            supplier.BaseMaterialSupplier();


            

            char LoopExit = 'y';
           
            
            while(LoopExit == 'y')
            {
                CandyBuilder Builder2000 = new CandyBuilder();
                Builder2000.Build(supplier.MaterialSupply, supplier.TasteSupply, supplier.ShapeSupply, supplier.AromaSupply, supplier.ColorSupply, supplier.Weight);

                Console.WriteLine("Would you like to generate another candy? (y/n)");
                LoopExit = char.Parse(Console.ReadLine());
                while (LoopExit!= 'y' && LoopExit != 'n')
                {
                    Console.WriteLine("Not a valid input. Try again.");
                    LoopExit = char.Parse(Console.ReadLine());
                }


            }

        }
    }
}
