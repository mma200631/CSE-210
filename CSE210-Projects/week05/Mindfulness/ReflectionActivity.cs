public class ReflectionActivity:Activity
{
    private string[] _prompts= new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions= new string[]
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different from others?",
        "What is your favorite thing about this experience?"
    };

    public ReflectionActivity(int duration): base(duration)
    {

    }

    public void StartReflection()
    {
        StartMessage("Reflection Activity","This activity will help you recognize ur strength and resilience");

        Random rand= new Random();
        Console.WriteLine("$\n{_prompts[rand.Next(_prompts.Length)]}");
        ShowSpinner(5);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Length)]);
            ShowSpinner(5);
            elapsed += 5;
        }

        EndMessage("Reflection Activity");
    }

    

}
