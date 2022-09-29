using System;
namespace FactoryPatternExercise
{
    public class Motorcyle : IVehicle 
    {
        public Motorcyle()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Motorcycle is driving.");
        }
    }
}

