namespace JSonSettingsConsoleApp;

public class Running
{
    public void Run()
    {
        Console.WriteLine("Input your name pls: ");
        var x = Console.ReadLine();

        Console.WriteLine($"Hello {x}");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}