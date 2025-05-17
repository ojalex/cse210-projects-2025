using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job();
        job1._companyName = "Microsoft"; 
        job1._jobTitle ="Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job1.WorkExperience();
    
        var job2 = new Job();
        job2._companyName = "USAID Nuru Ya Mtoto"; 
        job2._jobTitle ="Health Records and Information Officer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job2.WorkExperience();

        var myCv = new Resume();
        myCv._name = "Alex Otieno Juma";

        myCv._jobs.Add(job1);
        myCv._jobs.Add(job2);
        
        myCv.WorkExperience();
    }
}