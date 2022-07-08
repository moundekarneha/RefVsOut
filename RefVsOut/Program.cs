using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVsOut
{
    internal class Program
    {
        
        public static void Change(int i)
        {
            i = 80; 
        }

        public static void ChangeByRef( ref int i)
        {
            i = 90;
        }
        public static void ChangeByOut(out int i)
        {
            i = 100;
        }


        static void Main(string[] args)
        {
            int i=10;
            
            Change(i);
            Console.WriteLine("I = " + i); //it will print 10 - since it is taking as type value

            ChangeByRef(ref i);
            Console.WriteLine("Change by ref I = " + i);


            ChangeByOut(out i);
            Console.WriteLine("Change by out I = " + i);

            Console.ReadLine(); 

        }

    }
}
