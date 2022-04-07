using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Calculator
    {
        public int Multiply(int a, int b)
        { 
            return a * b;
        }

    }

    internal class Addition
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    internal class Subtract
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }

        internal int Div(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    internal class Divide
    {
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
