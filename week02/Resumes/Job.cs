// Job details class

public class Job
{
    // declare attributes or properties or member variables
    public string __company;
    public string __jobTitle;
    public int __startYear;
    public int __endYear;

    // declare constructors => early initialization
    public Job(string company, string jobtitle, int startyear, int endyear)
    {
        __company = company;
        __jobTitle = jobtitle;
        __startYear = startyear;
        __endYear = endyear;
    }

    // declare methods or behaviors
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{__jobTitle}, ({__company}), {__startYear}-{__endYear}");
    }


}
