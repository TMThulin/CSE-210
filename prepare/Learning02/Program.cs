using System;

class Program
{
    static void Main(string[] args) {
        Job job1 = new Job();
        job1._job-title = "Software Developer ";
        job1._company = "Google ";
        job1._start-year = 6789;
        job1._end-year = 7896;

        job1 job2 = new job1();
        job2._job-title = "AI Developer ";
        job2._company = "Open AI ";
        job2._start-year = 1234;
        job2._end-year = 9999;

        resume myresume = new resume();
        myresume._name = "King Joe ";
        myresume._job.Add(job1);
        myresume._job.Add(job2);

        myresume.Display();
    }
}