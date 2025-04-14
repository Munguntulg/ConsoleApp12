using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooniiMachine.AbstractCalc;

namespace TooniiMachine.Undsen
{
    //aimshigtai bailaa
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
        private double memory = 0;

        public void MemorySave()
        {
            memory = Result;
        }

        public void MemoryRecall()
        {
            Result = memory;
        }

        public void MemoryClear()
        {
            memory = 0;
        }
        public void Reset()
        {
            Result = 0;
        }


    }
}

