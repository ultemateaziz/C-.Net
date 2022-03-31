using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typeconverstion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit operation
            int myInt = 9; 
            double myDouble = myInt;
            Console.WriteLine(myDouble);
            
            //explisit operation
            double myDouble1 = 9.78; 
            int myInt1 = (int)myDouble;
            Console.WriteLine(myInt1);
            
            //boxing operation
            int m = 10;
            object om = m;
            m = 20;
            Console.WriteLine(m);
            Console.WriteLine(om);
            
            //unboxing operation
            int i = 30;
            object ob = i;
            int j = (int)ob;
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
