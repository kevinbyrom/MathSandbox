using System;
using System.Collections.Generic;


namespace MathSandbox.Waves
{
    public static class SineWave
    {
        public static IEnumerable<double> Create(double duration, int sampleRate = 44000)
        {
            double inc = (Math.PI * 2) / (duration * sampleRate);

            for (double i = 0; i < Math.PI * 2; i += inc)
            {
                yield return Math.Sin(i);
            }
        }
    }
}

