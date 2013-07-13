using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputOutputLibrary;
using CalculatorLibrary;
using Microsoft.Practices.Unity;
using CalculatorCommandParsingLibrary;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Modularity
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            UnityConfigurationSection configSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            configSection.Containers.Default.Configure(container);
            //configSection.Configure(container, "unity");
           

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            
            loop.Run();

        }

    }
}
