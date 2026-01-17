using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // job instance initialization of class constructors
        Job job1 = new Job("Microsoft", "Software Developer", 2023, 2028);
        Job job2 = new Job("Apple", "Manager", 2025, 2023);

        // job list and resume instance initialization of class constructor
        //  and add jobs to resume list
        List<Job> myJobs = new List<Job>();
        Resumes myResumes = new Resumes("Enssah Fayia Momoh", myJobs);
        myResumes.__jobs.Add(job1);
        myResumes.__jobs.Add(job2);

        // call the methods or behavior
        myResumes.Display();
    }
}