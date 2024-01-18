using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Power Production Specialist 2";
        job1._company = "Tucson Electric Power";
        job1._startDate = 2015;
        job1._endDate = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Assistant Control Room Operator";
        job2._company = "Tucson Electric Power";
        job2._startDate = 2023;
        job2._endDate = 2024;


        Resume myResume = new Resume();
        myResume._name = "William Chad Finch";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}