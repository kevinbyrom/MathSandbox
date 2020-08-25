using System;
using System.Collections.Generic;


namespace MathSandbox.Operands
{
    public class Constant : IValueProvider
    {
        private double val;


        public Constant(double val)
        {
            this.val = val;
        }


        public double GetValue(Dictionary<string, double> state = null)
        {
            return this.val;
        }
    }
}