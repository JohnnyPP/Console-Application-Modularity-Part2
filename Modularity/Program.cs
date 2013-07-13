using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputOutputLibrary;

namespace Modularity
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorReplLoop loop = new CalculatorReplLoop();
            loop.OutputService = new MsgBoxOutputService();
            //loop.OutputService = new ConsoleOutputService();
            loop.Run();
        }

    }
}
