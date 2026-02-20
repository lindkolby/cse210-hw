public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string __problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        __problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {__problems}";
    }
}