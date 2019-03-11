using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExampleCars
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
        // Is the car alive or dead?
        private bool carIsDead;
        // Class constructors.
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
            carIsDead = false;
        }

        // This delegate works in conjunction with the
        // Car’s events.
        public delegate void CarEngineHandler(string msg);
        // This car can send these events.
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        //// step 4: Implement the Accelerate() method to invoke the delegate’s
        //// invocation list under the correct circumstances.
        //public void Accelerate(int delta)
        //{
        //    // If this car is "dead," send dead message.
        //    if (carIsDead)
        //    {
        //        if (listOfHandlers != null)
        //            listOfHandlers(@"Sorry, this car is dead...");
        //    }
        //    else
        //    {
        //        CurrentSpeed += delta;
        //        // Is this car "almost dead"?
        //        if (10 == (MaxSpeed - CurrentSpeed)
        //            && listOfHandlers != null)
        //        {
        //            listOfHandlers(@"Careful buddy! Gonna blow!");
        //        }
        //        if (CurrentSpeed >= MaxSpeed)
        //            carIsDead = true;
        //        else
        //            Console.WriteLine(@"CurrentSpeed = {0}", CurrentSpeed);
        //    }
        //}
    }
}
