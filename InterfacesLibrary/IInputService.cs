using System;
namespace InputOutputLibrary
{
    public interface IInputService
    {
        Modularity.Arguments ReadArguments();
        string ReadCommand();
    }
}
