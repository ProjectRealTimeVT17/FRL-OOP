using ClassExempel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExempel.Delegate;
using ClassExempel.Utils;

namespace ClassExempel
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myCat.MakeSound();
            myDog.MakeSound();

            Output output = new Output();

            WriteToConsoleDelegate wtc = new WriteToConsoleDelegate(output.ReportToBoss1);
            wtc += output.ReportToBoss2;
            myDog.OnValueChange += wtc;


            myDog.Name = "Fido";
            myDog.Color = "Brown";

            Console.ReadKey();
        }

    }
}
