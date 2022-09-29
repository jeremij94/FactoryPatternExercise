using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {

            
            if (numberOfTires == 2)
            {
                return new Motorcyle();
            }

            else if (numberOfTires == 4)
            {
                return new Car();
            }

            else
            {
                return new Car();
            }
        }
        
    }

}

