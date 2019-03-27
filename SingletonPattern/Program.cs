using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        public static void Main()
        {
            var sealedobject = SingletonPattern.SingletonObject;
            sealedobject.Message = "Hi this is shubhanshu";
            Console.WriteLine(sealedobject.Message);
            var sealedobject2 = SingletonPattern.SingletonObject;
            sealedobject2.Message = "Hi I tried to create another object";
            Console.WriteLine(sealedobject.Message);
            Console.ReadLine();
        }
    }
}
