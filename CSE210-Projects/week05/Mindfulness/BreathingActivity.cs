public class BreathingActivity:Activity
{
    public BreathingActivity(int duration): base(duration)
    {

    }

    public void StartBreathing()
    {
        StartMessage("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.");

        for (int i= 0; i< _duration/6; i++)
        {
            Console.WriteLine("\nBreath in.....");
            ShowCountDown(3);
            Console.WriteLine("\nBreath out....");
            ShowCountDown(3);
        }

        EndMessage("Braething Activity");
    }

}