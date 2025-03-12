public class Job {
    public string _jobTitle;
    public string _company;
    public int _startyear;
    public int _endYear;

    public Job()
    {

    }

    public void showInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startyear} - {_endYear}");
    }

    
}