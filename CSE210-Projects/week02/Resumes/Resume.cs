using System.Linq.Expressions;

public class Resume{
    public string _name;
    public  List<Job> _job = new List<Job>();

    public Resume()
    {

    }

    public void DisplayResume()
    {
        Console.WriteLine($"Your Name: {_name}");
    }
}