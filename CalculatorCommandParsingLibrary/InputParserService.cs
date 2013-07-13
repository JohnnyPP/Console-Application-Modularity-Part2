using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularity
{
    public class InputParserService : CalculatorCommandParsingLibrary.IInputParserService
    {
        public CommandTypes ParseCommand(string command)
        {
            return ((CommandTypes)Enum.Parse(typeof(CommandTypes), command));
        }
    }
}
