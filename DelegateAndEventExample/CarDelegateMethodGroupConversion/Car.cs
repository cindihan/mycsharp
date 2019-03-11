using System;

namespace CarDelegateMethodGroupConversion
{
   //Car is create as the publisher
    public class Car
    {

        // Internal state data.
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
            //carIsDead = false;
        }

        //step 1: create a delegate
        public delegate void CarEngineHandler(string msgForCaller);

        //step 2: create a object of the delegate
        private CarEngineHandler listOfHandlers;

        //step 3: Add a registration function for a caller
        public void RegisterWithCarEngine(CarEngineHandler handler)
        {
            //if (listOfHandlers == null)
            //    listOfHandlers = handler;
            //else
            //    Delegate.Combine(listOfHandlers, handler);
            listOfHandlers += handler;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler
            methodToCall)
        {
            listOfHandlers -= methodToCall;
        }
        // step 4: Implement the Accelerate() method to invoke the delegate’s
        // invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            // If this car is "dead," send dead message.
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers(@"Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Is this car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed)
                    && listOfHandlers != null)
                {
                    listOfHandlers(@"Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine(@"CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
