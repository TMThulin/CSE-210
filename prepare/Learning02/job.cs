using System;

public class job {
    public string _job-title;

    public string _company;

    public int _start-year;

    public int _end-year;

    public void Display() {
        Console.WriteLine($"{_job-title} ({_company}) {_start-year} {_end-year}");
    }
}