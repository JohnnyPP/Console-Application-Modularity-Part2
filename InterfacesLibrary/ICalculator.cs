using System;
namespace CalculatorLibrary
{
    public interface ICalculator
    {
        int Add(global::Modularity.Arguments args);
        int Div(global::Modularity.Arguments args);
        int Execute(global::Modularity.CommandTypes commandType, global::Modularity.Arguments args);
        int Mul(global::Modularity.Arguments args);
        int Sub(global::Modularity.Arguments args);
    }
}
