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

            //Dog myDog = new Dog("Fido", "Brown", Gender.Male, 7);
            Dog myDog = new Dog();

            Output output = new Output();

            WriteToConsole wtc = new WriteToConsole(output.ReportToBoss1);
            wtc += output.ReportToBoss2;
            myDog.OnValueChange = wtc;

            myDog.Name = "Fido";
            myDog.Color = "Brown";

            Console.ReadKey();
        }

    }
}
