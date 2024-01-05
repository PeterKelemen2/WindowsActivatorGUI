namespace WindowsActivatorGUI;

public class Utils
{
    public static void Debug(string message)
    {
        System.Diagnostics.Debug.WriteLine(message);
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void PrintHeader()
    {
        Print("   === Windows Activator ===");
        Print("");
        Print(" Type Your Windows version's number");
        
    }

    public static string GetInputFromUser()
    {
        string input = Console.ReadLine();
        return input;
    }

    public static void Home(object sender, EventArgs e)
    {
        Print("Button Clicked");
    }
}