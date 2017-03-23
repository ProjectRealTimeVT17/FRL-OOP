using ClassExempel.Model;
using System;
using ClassExempel.Delegate;
using ClassExempel.Interface;
using ClassExempel.Utils;

namespace ClassExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();

            myCat.MakeSound();
            myDog.MakeSound();

            Output output = new Output();
            WriteToConsoleDelegate wtc = new WriteToConsoleDelegate(output.ReportToBoss1);
            wtc += output.ReportToBoss2;
            myDog.OnValueChange += wtc;
            myCat.OnValueChange += wtc;

            myDog.Name = "Fido";
            myCat.Name = "Gustav";

            //string[] animalNames = new string[2];

            //var animalNames = new string[2];
            //animalNames[0] = myCat.Name;
            //animalNames.SetValue(myDog.Name,1);

            //string[] animalNames = new string[2] {myCat.Name, myDog.Name};
            
            var animalNames = new[] {myCat.Name,myDog.Name};
            foreach (var animalName in animalNames)
            {
                Console.WriteLine("array index " + Array.IndexOf(animalNames, animalName) +": " + animalName);
            }

            for (int i = 0; i < animalNames.Length; i++)
            {
                Console.WriteLine("array index " + i + ": " + animalNames[i]);
            }
            

            Console.ReadKey();
        }

    }
}
