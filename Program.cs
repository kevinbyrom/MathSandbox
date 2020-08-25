using System;
using System.Collections.Generic;
using System.Linq;
using MathSandbox.Waves;
using MathSandbox.Operands;
using MathSandbox.Operators;


namespace MathSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatAndRangeExample();
            SineWaveExample();
            SimpleExpressionExample();
            SimpleVariableExpressionExample();

            Console.WriteLine("Done");
        }


        private static void RepeatAndRangeExample()
        {
            Console.WriteLine("Enumerable.Repeat...");
            
            foreach (var a in Enumerable.Repeat(0, 5))
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("Enumerable.Range...");

            foreach (var a in Enumerable.Range(0, 5))
            {
                Console.WriteLine(a);
            }
        }


        private static void SineWaveExample()
        {
            Console.WriteLine("SinWave...");

            var wave = SineWave.Create(1.0, 100);

            foreach (var a in wave)
            {
                Console.WriteLine("{0:0.00}", a);
            }


            Console.WriteLine("Amplified wave...");

            foreach (var a in wave.Amp(2))
            {
                Console.WriteLine("{0:0.00}", a);
            }

            Console.WriteLine("Wave sum...");
            Console.WriteLine("{0:0.00}", wave.Amp(3).Sum());
        }


        private static void SimpleExpressionExample()
        {
            Console.WriteLine("Simple expression...");

            double val = 5.0;

            var exp = val.Multiply(2.0);

            Console.WriteLine("{0:0.00}", exp.GetValue());


            exp = (val / 2.0).Multiply(5);

            Console.WriteLine("{0:0.00}", exp.GetValue());
        }

        private static void SimpleVariableExpressionExample()
        {
            Console.WriteLine("Simple variable expression...");

            Variable x = new Variable("x");

            var exp = x.Multiply(2.0);

            var state = new Dictionary<string, double>();
            state.Add("x", 7.0);

            Console.WriteLine("{0:0.00}", exp.GetValue(state));
        }
    }
}
