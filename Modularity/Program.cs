using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputOutputLibrary;
using CalculatorLibrary;
using Microsoft.Practices.Unity;
using CalculatorCommandParsingLibrary;

namespace Modularity
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            
            
            container.RegisterType<ICalculator, Calculator>();
            container.RegisterType<IInputService, ConsoleInputService>();
            container.RegisterType<IOutputService, ConsoleOutputService>();
            container.RegisterType<IInputParserService, InputParserService>();

            container.RegisterType<ICalculatorReplLoop, CalculatorReplLoop>();

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            
            loop.Run();

        }

    }
}
