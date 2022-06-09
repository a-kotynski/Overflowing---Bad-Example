using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Program
    {
        static void Main(string[] args)
        {
            //this whole example doesn't work *shrug*
            checked
            {
                byte number = 255;
                number = number + 1;
            }
            
            //byte number = 255;
            //number = number + 1; // instead of 0 a program doesn't compile
            //Console.WriteLine(number);
        }
    }
}