using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); 

    public void DisplayResume()
    {
        foreach (Job j in _jobs)
        {
        Console.WriteLine($"{_name} ({j})");
        }
    }
}