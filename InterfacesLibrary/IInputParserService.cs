using System;
namespace CalculatorCommandParsingLibrary
{
    public interface IInputParserService
    {
        global::Modularity.CommandTypes ParseCommand(string command);
    }
}
