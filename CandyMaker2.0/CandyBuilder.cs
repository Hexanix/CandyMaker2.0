using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMaker2._0
{
    class CandyBuilder
    {
        public void CandyBuild(string CandyColor, string CandyShape, string CandyMaterial)
        {
            Console.WriteLine("This is a " + CandyColor + CandyShape + " candy made out of " + CandyMaterial + ".");
        }


        public void WrapBuild(string WrapColor, string WrapMaterial)
        {
            Console.WriteLine("It is wrapped in a " + WrapColor + " wrapping made out of " + WrapMaterial);
        }

    }
}
