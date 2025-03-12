using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1= new Job();
        job1._jobTitle= "Software Development";
        job1._company="Google";
        job1._startyear=2006;
        job1._endYear=2020;
        job1.showInformation();

        Job job2=new Job();
        job2._jobTitle="Manager";
        job2._company="Microsoft";
        job2._startyear= 2021;
        job2._endYear=2024;
        job2.showInformation();

        Resume myResume= new Resume();
        myResume._name="Assumpta Chidinma Okpanachi";
        myResume._job.Add(job1);
        myResume._job.Add(job2);
        myResume.DisplayResume();
        Console.WriteLine("Job:" + myResume._job[0]._jobTitle);
        Console.WriteLine("Job:" + myResume._job[1]._jobTitle);

    }
}