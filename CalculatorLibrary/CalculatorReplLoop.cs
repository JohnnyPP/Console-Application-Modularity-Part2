using CalculatorCommandParsingLibrary;
using CalculatorLibrary;
using InputOutputLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularity
{
    public class CalculatorReplLoop : ICalculatorReplLoop
    {
        public CalculatorReplLoop(ICalculator calculator, IInputService inputService, IOutputService outputService,
            IInputParserService inputParserService)
        {
            this.calculator = calculator;
            this.inputService = inputService;
            this.outputService = outputService;
            this.parsingService = inputParserService;

        }


        ICalculator calculator;
        IInputService inputService;
        IOutputService outputService;
        IInputParserService parsingService;

        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = parsingService.ParseCommand(command);
                    Arguments args = inputService.ReadArguments();
                    outputService.WriteMessage(calculator.Execute(commandType, args).ToString());
                }
                catch
                {

                    outputService.WriteMessage("Mistake!");
                }

            }
            

        }
    }
}
