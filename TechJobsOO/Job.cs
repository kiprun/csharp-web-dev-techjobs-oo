using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; set; } 
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()//Constructor to initialize id field with a unique value. No parameters
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobtype, CoreCompetency jobCoreCompentency): this()
            //Constructor to assign values to parameters.  : this() calls id constructor
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobtype;
            JobCoreCompetency = jobCoreCompentency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString() //Needed so that ToString tests will pass
        {
            //returns string with each field in seperate line
            string idField = $"\nID: {Id}\n";
            string employeeNameField = $"Name: {Name}\n";
            string employerNameField = $"Employer: {EmployerName}\n";
            string jobLocationField = $"Location: {EmployerLocation}\n";
            string positionField = $"Position Type: {JobType}\n";
            string competencyField = $"Core Competency: {JobCoreCompetency}\n";

            //returns string for each field that is blank
            if (Name == null)
            {
                employeeNameField = $"Name: Data not available\n";
            }
            if (EmployerName == null)
            {
                employerNameField = $"Employer: Data not available\n";
            }
            if (EmployerLocation == null)
            {
                jobLocationField = $"Location: Data not available\n";
            }
            if (JobType == null)
            {
                positionField = $"Position Type: Data not available\n";
            }
            if (JobCoreCompetency == null)
            {
                competencyField = $"Core Competency: Data not available\n";
            }

            string sampleJob = idField + employeeNameField + employerNameField + jobLocationField + positionField + competencyField;
            return sampleJob;
        }




    }
}
