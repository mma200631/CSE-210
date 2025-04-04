public class ListingActivity:Activity
{
    private string[] _prompts= new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration): base(duration)
    {

    }

     public void StartListing()
    {
        StartMessage("Listing Activity", "This activity will help you reflect on the good things in your life.");

        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Length)]}");
        ShowCountDown(5);

        Console.WriteLine("\nStart listing as many things as you can...");
        List<string> responses = new List<string>();

       DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndMessage("Listing Activity");
    }
}