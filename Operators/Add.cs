using System;
using System.Collections.Generic;


namespace MathSandbox.Operators
{
    public class AddOperator : OperatorBase
    {
        public AddOperator() : base()
        {            
        }

        public AddOperator(IValueProvider left, IValueProvider right) : base(left, right)
        {
        }

        public override double GetValue(Dictionary<string, double> state = null)
        {
            return this.Left.GetValue(state) + this.Right.GetValue(state);       
        }
    }
}