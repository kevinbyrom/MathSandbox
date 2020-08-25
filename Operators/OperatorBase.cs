using System;
using System.Collections.Generic;


namespace MathSandbox.Operators
{
    public abstract class OperatorBase : IValueProvider
    {
        public IValueProvider Left;
        public IValueProvider Right;


        public OperatorBase()
        {
        }


        public OperatorBase(IValueProvider left, IValueProvider right)
        {
            this.Left = left;
            this.Right = right;
        }


        public abstract double GetValue(Dictionary<string, double> state = null);
    }
}