using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
       List<Activity> activities = new List<Activity>
        {   new Running("03 nov 2022", 25, 14.5),
            new Cycling("03 Nov 2022", 20, 12.0),
            new Swimming("03 Nov 2022", 15, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}