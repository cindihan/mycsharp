using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventExampleCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            // First, make a Car object.
            Car c1 = new Car("SlugBug", 100, 10);
            //register the event to subscriber or invoke the event
            //
            // Now, tell the car which method to call
            // when it wants to send us messages.
            c1.RegisterWithCarEngine(new
                Car.CarEngineHandler(OnCarEngineEvent));
            // so we can unregister later.
            Car.CarEngineHandler handler2 = new
                Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);
            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            // Unregister from the second handler.
            c1.UnRegisterWithCarEngine(handler2);
            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        private static void OnCarEngineEvent2(string msgforcaller)
        {
            Console.WriteLine("=> {0}", msgforcaller.ToUpper());
        }

        // This is the target for incoming events.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }
}
