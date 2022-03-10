//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DesignPatternConsole.Patterns.Builder;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builderPattern = new CarBuilder()
                .SetName("BMW")
                .SetColor("Black")
                .SetManifactureDate(DateTime.UtcNow);
            
            var test = builderPattern.GetInstance();
        }
    }
}