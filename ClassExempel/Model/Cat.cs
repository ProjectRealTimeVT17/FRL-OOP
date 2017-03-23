using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExempel.Model
{
    class Cat : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Mjau Mjau");
        }
    }

}
