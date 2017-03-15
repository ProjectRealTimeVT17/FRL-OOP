using ClassExempel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();
            //myDog.Name = "Fido";
            //myDog.Gender = Gender.Male;
            //myDog.Age = 7;

            //Dog myDog = new Dog()
            //{
            //    Name = "Fido",
            //    Gender = Gender.Male,
            //    SetAge = 7,
            //    Color = null
            //};

            Dog myDog = new Dog("Fido", "Brown", Gender.Male, 7);
            //Visar att property bara accepterar värdet "Brown" som är en sträng som inte är null, empty eller white-space
            //myDog.Color = "Brown";
            //myDog.Color = "";
            //myDog.Color = " ";




            Console.WriteLine(myDog.Bark());
            Console.WriteLine((int)Gender.Male);
            Console.WriteLine("My dogs name is: " + myDog.Name);
            Console.WriteLine("My dogs gender is: " + myDog.Gender);
            Console.WriteLine("My dogs age is: " + myDog.Age);
            Console.WriteLine("My date of birth is: " + myDog.DateofBirth);
            Console.WriteLine("My dogs color is: " + myDog.Color);

            Cat myCat = new Cat();

            Console.ReadKey();
        }
    }
}
