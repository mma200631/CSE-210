public class Assignment
{
    protected string _studentName;
    private string _topic;
     
    public Assignment(string name, string topic)
    {
        _studentName=name;
        _topic=topic;
    }

    public string GetSummary()
    {
        return $"Student Name: {_studentName}, Topic: {_topic}";
    }

}