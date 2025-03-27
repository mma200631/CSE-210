public class Refrence
{
    private string  _book;
    private int _chapter;
    private int _startVerse;
    public int? _endVerse;

    public Refrence(string book, int chapter, int startVerse, int? endVerse=null)
    {
        _book=book;
        _chapter=chapter;
        _startVerse=startVerse;
        _endVerse=endVerse;
    }

    public string GetDisplayText()
    {
        return _endVerse.HasValue
        ?$"{_book} {_chapter}: {_startVerse}-{_endVerse}"
        :$"{_book} {_chapter}: {_startVerse}";
    }
}