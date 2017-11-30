using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nier_Auto
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(2, 2, 1);
            Animal rat = new Animal(6, 8, 1);
            Animal.Hunt(cat, rat);
            
        }
    }

}
