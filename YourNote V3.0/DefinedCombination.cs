using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopNote
{
    class DefinedCombination
    {
        char prefix;
        char replaced;
        char replacement;
        public char Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        public char Replaced
        {
            get { return replaced; }
            set { replaced = value; }
        }



        public char Replacement
        {
            get { return replacement; }
            set { replacement = value; }
        }
    }
}
