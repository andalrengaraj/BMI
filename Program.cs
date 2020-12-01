using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace height1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in cms");
            double height = Convert.ToDouble(Console.ReadLine());

             double heightft = height / 30.48;

             double heightininches = height / 2.54;


             Console.WriteLine("Your Height in feet:" +heightft);
             Console.WriteLine("Your Height in inches:" +heightininches);

        }
    }
}
