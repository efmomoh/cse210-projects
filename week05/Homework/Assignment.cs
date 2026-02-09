// Parent, base, or super class

public class Assignment
{
    // declare member variables
    private string _studentName = "";
    private string _topic = "";

    // create constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // declare a getter for student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // declare setter setter for student name
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    // declare getter for topic
    public string GetTopic()
    {
        return _topic;
    }

    // declare setter for topic
    public void SetTopic(string topic)
    {
        _topic = topic;
    }


    // declare member function
    public string GetSummary()
    {
        return $"{_studentName} ~ {_topic}";
    }
}