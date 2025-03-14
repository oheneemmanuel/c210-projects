using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Development";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "cyber security";
        job2._company = "Brains Tech";
        job2._startYear = 2019;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Ohene Emmanuel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}