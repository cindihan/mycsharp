using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"************ Simple Delegate Example*************");
            
            // .NET delegates can also point to instance methods as well.
            SimpleMath m=new SimpleMath();
            
            Console.ReadKey();
        }
    }
}
