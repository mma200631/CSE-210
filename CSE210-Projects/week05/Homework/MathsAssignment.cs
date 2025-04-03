public class MathsAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathsAssignment(string textbooksection, string problems, string name, string topic ) : base(name, topic)
    {
        _textbookSection=textbooksection;
        _problems=problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section:{_textbookSection}, Problem:{_problems}";
    }
}