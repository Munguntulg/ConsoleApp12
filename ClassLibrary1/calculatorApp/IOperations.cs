using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooniiMachine.AbstractCalc
{
    public interface IOperations
    {
        /// <summary>
        /// ugsun toog nemne
        /// </summary>
        /// <param name="number"></param>
        void Add(double number);
        /// <summary>
        /// ugsun toog hasna
        /// </summary>
        /// <param name="number"></param>
        void Subtract(double number);
        /// <summary>
        /// ugsun toog urjine
        /// </summary>
        /// <param name="number"></param>
        void Multiply(double number);
        /// <summary>
        /// ugsun toog huwaana
        /// </summary>
        /// <param name="number"></param>
        void Divide(double number);
        /// <summary>
        /// Toog ankhnii utga (0) ruu butsaana
        /// </summary>
        void Reset(); 
        /// <summary>
        /// Odoo bgaa ur dung sanah oind hadgalna
        /// </summary>
        void MemorySave();
        /// <summary>
        /// Sanah oind hadgalagdsan utgiig sergeene
        /// </summary>
        void MemoryRecall();

        /// <summary>
        /// Sanah oig tseverlene
        /// </summary>
        void MemoryClear();
    }
}

