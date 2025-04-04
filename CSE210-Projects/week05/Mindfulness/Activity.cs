public class Activity
{
    protected int _duration;
    
    public Activity (int duration)
    {
        _duration= duration;
    }

    public void StartMessage(string activityName, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {activityName}.");
        Console.WriteLine($"{description}");
        Console.WriteLine("Enter duration (in seconds):");
        _duration=int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine("\nGood Job !Your have completed this activity.");
        ShowSpinner(3);
        Console.WriteLine($"You  have completed {activityName} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i>0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        for(int i=0; i<seconds *4; i++)
        {
            Console.Write($"\r{spinner[i%4]}");
            Thread.Sleep(250);
        }

        Console.Write("\r");
    }
}