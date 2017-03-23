using ClassExempel.Delegate;

namespace ClassExempel.Interface
{
    internal interface IAnimal
    {
        void MakeSound();
        string Name { get; set; }

        event WriteToConsoleDelegate OnValueChange;
    }
}