using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooniiMachine.AbstractCalc
{
    public interface IOperations
    {
        void Add(double number);
        void Subtract(double number);
        void Multiply(double number);
        void Divide(double number);
    }
}

