using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooniiMachine.AbstractCalc;

namespace TooniiMachine.Undsen
{
    public class BasicCalculator : Calculator, IOperations
    {
        public void Add(double number)
        {
            Result += number;
        }

        public void Subtract(double number)
        {
            Result -= number;
        }
        public void Multiply(double number)
        {
            Result *= number;
        }
        public void Divide(double number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            Result /= number;
        }
    }
}

