using System;
using System.Collections.Generic;


namespace MathSandbox.Waves
{
    public static class WaveExtensions
    {
        public static IEnumerable<double> Amp(this IEnumerable<double> vals, double power)
        {
            foreach (var i in vals)
            {
                yield return i * power;
            }
        }
    }
}