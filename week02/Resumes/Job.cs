using System;

public class Job
{
    public string _JobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        console.WriteLine($"{_JobTitle} ({_company}) {_startYear}-{_endYear}"); 
    }
}