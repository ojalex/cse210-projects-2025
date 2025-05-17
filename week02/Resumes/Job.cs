using System.Reflection.Metadata;
//Class Name Job
public class Job
{
    //Data/Fields/Attribute of the class:
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    
    //Behaviors/Method:
    public void WorkExperience()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
        //Displays "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    }

    

}