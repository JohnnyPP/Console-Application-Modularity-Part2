using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularity
{
    public class ConsoleOutputService : InputOutputLibrary.IOutputService
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
