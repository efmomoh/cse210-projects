// child, derived or sub class => 1

public class MathAssignment : Assignment
{
    // declare membervariables or attributes
    private string _textbookSection = "";
    private string _problems = "";

    // declare constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // declare member functions
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}