using System;
using System.Collections.Generic;
using MathSandbox.Operands;

namespace MathSandbox.Operators
{
    public class MultiplyOperator : OperatorBase
    {
        public MultiplyOperator() : base()
        {            
        }

        public MultiplyOperator(IValueProvider left, IValueProvider right) : base(left, right)
        {
        }

        public override double GetValue(Dictionary<string, double> state = null)
        {
            return this.Left.GetValue(state) * this.Right.GetValue(state);       
        }
    }

    public static class MultiplyExtensions
    {
        public static IValueProvider Multiply(this IValueProvider left, double right)
        {
            return new MultiplyOperator(left, new Constant(right));
        }

        public static IValueProvider Multiply(this IValueProvider left, IValueProvider right)
        {
            return new MultiplyOperator(left, right);
        }

        public static IValueProvider Multiply(this double left, double right)
        {
            return new MultiplyOperator(new Constant(left), new Constant(right));
        }

        public static IValueProvider Multiply(this double left, IValueProvider right)
        {
            return new MultiplyOperator(new Constant(left), right);
        }
    }
}