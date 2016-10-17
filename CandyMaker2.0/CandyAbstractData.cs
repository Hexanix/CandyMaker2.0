using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMaker2._0
{
    abstract class CandyAbstractData
    {
        //These are abstracts that are the basis of all candy
        public abstract string CandyType { get; set; }
        public abstract string CandyShape { get; set; }
        public abstract string CandyMaterial { get; set; }
        public abstract string CandyTaste { get; set; }
        public abstract string CandySpecificProperty { get; set; }

        //these are variables to hold the optional values for the candy
        protected string candyColor { get; set; }
        protected string candyAroma { get; set; }
        protected int candyWeight { get; set; }
    }
}



    

