//RESUME BLUEPRINT

public class Resumes
{
    // declare attributes or properties or member variables
    public string __personName;
    public List<Job> __jobs = new List<Job>();

    // declare class constructor => early initialization
    public Resumes(string name, List<Job> jobs)
    {
        __personName = name;
        __jobs = jobs;
    }

    // declare methods or behaviors
    public void Display()
    {
        Console.WriteLine($"Name: {__personName}");
        Console.WriteLine($"Jobs: ");

        // loop over each item in the object or class (Job) list
        foreach (Job job in __jobs)
        {
            job.DisplayJobDetails();
        }
    }
}