using System;
using System.Collections.Generic;


namespace MathSandbox.Operands
{
    public class Variable : IValueProvider
    {
        private string varName;


        public Variable(string varName)
        {
            this.varName = varName;
        }


        public double GetValue(Dictionary<string, double> state = null)
        {
            return state[this.varName];
        }
    }
}