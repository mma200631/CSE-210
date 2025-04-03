public class WritingAssignment:Assignment
{
    private string _title;

    public WritingAssignment(string title, string topic, string name): base(topic, name)
    {
        _title=title;
    } 

    public string GetWritingInformation()
    {
        return $"Title: {_title} by {_studentName}";
    }
}