using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
     class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
       
            int sum = 0;
            sum = calc.Multiply(3, 5);
            Console.WriteLine("sum of {0}", sum);


            Addition Adder = new Addition();

            int Compute = 0;
            Compute = Adder.Add(3, 5);
            Console.WriteLine("sum of {0}", Compute);


            Subtract takeaway = new Subtract();
            int minus = 0;
            minus = takeaway.Sub(3, 5);
            Console.WriteLine("sum of {0}", minus);


            Divide Division = new Divide();

            int Div = 0;
            Div = Division.Div(12, 3);
            Console.WriteLine("sum of {0}", Div);


            Console.ReadLine();


        }
    }
}
