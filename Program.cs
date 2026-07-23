//Variables and Start Settings
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

DateTime datatimeconsole = DateTime.Now;
Console.Title = $"CsConsole 1: {datatimeconsole} ";
//Endless While For Console Don't Quit
while (true)
{
    datatimeconsole = DateTime.Now;
    Console.Write($"CsConsole1: {datatimeconsole} ");
    string? InputConsole = Console.ReadLine();
    Console.Title = $"CsConsole1: {InputConsole}";

    //Comands
    if (InputConsole == "Help")
    {
        Console.WriteLine("CsConsole Commands:");
        Console.WriteLine("ConsolePrint: Enter Your Text In Console");
        Console.WriteLine("ConsolePrintRandom: Enter 'ConsolePrintRandom' For Print Random in Console ");
        Console.WriteLine("Clear: Clear Console");
        Console.WriteLine("Color: Change Color Text");
        Console.WriteLine("Exit: Close Program");
        Console.WriteLine("TimeNow: Show Your Time Now");
        Console.WriteLine("ChangeNameWindow: Change Name This Window Console");
        Console.WriteLine("Info: Show All Info For This App");
        if (InputConsole == "ConsolePrint")
        {
            Console.WriteLine("Enter what you want to output.");
            string? InputConsolePrint = Console.ReadLine();
            Console.WriteLine(InputConsolePrint);
        }
        if (InputConsole == "ConsolePrintRandom")
        {
            Console.Write("Enter 1 Random");
            int ConsoleRandomOne = int.Parse(Console.ReadLine());
            Console.Write("Enter 2 Random");
            int ConsoleRandomTwo = int.Parse(Console.ReadLine()!);
            await Task.Delay(1000);
            Console.WriteLine(Random.Shared.Next(ConsoleRandomOne, ConsoleRandomTwo));
        }
        if (InputConsole == "Clear")
        {
            Console.Clear();
        }
        if (InputConsole == "Color")
        {
            Console.Write("Enter Color For Text ");
            string ColorTextConsole = Console.ReadLine()!;
            if (ColorTextConsole == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The text has been successfully changed to Green!");
            }
            if (ColorTextConsole == "White")
            {
                Console.ResetColor();
                Console.WriteLine("The text has been successfully changed to White!");
            }
            if (ColorTextConsole == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The text has been successfully changed to Red!");
            }
            if (ColorTextConsole == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The text has been successfully changed to Blue!");
            }
        }
        if (InputConsole == "Exit")
        {
            Environment.Exit(0);
        }
        if (InputConsole == "TimeNow")
        {
            Console.WriteLine(datatimeconsole);
        }
        if (InputConsole == "ChangeNameWindow")
        {
            Console.Write("Enter New Name For This Window ");
            string NewWindowName = Console.ReadLine()!;
            Console.Title = NewWindowName;
        }
        if (InputConsole == "Info")
        {
            Console.WriteLine("CsConsole 1 Info:");
            Console.WriteLine("Version: 1.1.0");
            Console.WriteLine("Creator: Erpolkk");
            Console.WriteLine("All Commands: 7");
            Console.WriteLine("Created: 22.07.2026");

        }
        else if (InputConsole != "Help" && InputConsole != "ConsolePrint" && InputConsole != "ConsolePrintRandom" && InputConsole != "Clear" && InputConsole != "Color" && InputConsole != "Exit" && InputConsole != "TimeNow" && InputConsole != "ChangeNameWindow" && InputConsole != "Info")
        {
            Console.WriteLine("Error 1444x7: Command Not Found, You can find commands by typing \"Help\"");
            Console.Title = $"Error 1444x7: Command Not Found! {datatimeconsole}";
        }




    }
}