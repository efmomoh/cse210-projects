// sub class, child or derived class => 2

public class WritingAssignment : Assignment
{
    // declare member variables
    private string _title = "";


    // create a constructor 
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Title: {_title} by {GetStudentName()}";
    }
}