using System;
using System.Text;
namespace TechJobsOOAutoGraded6
{
	public class Job : JobField
	{
        

        // public int Id { get; }
        // private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            // Id = nextId;
            // nextId++;
        }

        public Job(string name, Employer employer, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
            
            // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        // public override bool Equals(object obj)
        // {
        //     return obj is Job job &&
        //     Id == job.Id;
        // }

        // public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string emptyField = "Data not available";

            // string[] fieldList = {Name ?? emptyField, EmployerName.Value ?? emptyField, EmployerLocation.Value ?? emptyField, JobType.Value ?? emptyField, JobCoreCompetency.Value ?? emptyField};

            // string[] labels = {"Name: ", "Employer: ", "Location: ", "Position Type: ", "Core Competency: "};
            StringBuilder newStr = new StringBuilder();

            newStr.Append("\n");
            newStr.Append($"ID: {this.Id}\n");
            newStr.Append("Name: " + (Name ?? emptyField) + "\n");
            newStr.Append("Employer: " + (EmployerName != null && EmployerName.Value != "" ? EmployerName.Value : emptyField) + "\n");
            newStr.Append("Location: " + (EmployerLocation != null && EmployerLocation.Value != "" ? EmployerLocation.Value : emptyField) + "\n");
            newStr.Append("Position Type: " + (JobType != null && JobType.Value != "" ? JobType.Value : emptyField) + "\n");
            newStr.Append("Core Competency: " + (JobCoreCompetency != null && JobCoreCompetency.Value != "" ? JobCoreCompetency.Value : emptyField) + "\n");            

            return newStr.ToString();
        }
    }
}

