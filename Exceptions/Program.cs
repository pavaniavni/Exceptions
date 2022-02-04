using System;
using System.Collections.Generic;
using System.Text;

namespace SeleadClass
{

    class Exception
    {
        public static void Main()
        {
            try
            {
                
                string val = null;
                int res = int.Parse(val);
            }
            
            catch (ArgumentNullException ex2)
            {
                Console.WriteLine("Argument null exception "+ ex2.Message);
            }


            Console.WriteLine();
        }
    }
}
