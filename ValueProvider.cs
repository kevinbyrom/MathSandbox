using System.Collections.Generic;


namespace MathSandbox
{
    public interface IValueProvider
    {
        double GetValue(Dictionary<string, double> state = null);
    }
}