using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobtype, CoreCompetency jobCoreCompentency): this()
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
            //returns sample with each field in seperate line
            string idField = $"\nID: {Id}\n";
            string employeeNameField = $"Name: {Name}\n";
            string employerNameField = $"Employer: {EmployerName}\n";
            string jobLocationField = $"Location: {EmployerLocation}\n";
            string positionField = $"Position Type: {JobType}\n";
            string competencyField = $"Core Compentency: {JobCoreCompetency}\n";

            //returns sample for each field that is blank
            if (employeeNameField == null)
            {
                employeeNameField = $"\nID: Data not available";
            }
            if (employerNameField == null)
            {
                employerNameField = $"\nID: Data not available";
            }
            if (jobLocationField == null)
            {
                jobLocationField = $"\nID: Data not available";
            }
            if (positionField == null)
            {
                positionField = $"\nID: Data not available";
            }
            if (competencyField == null)
            {
                competencyField = $"\nID: Data not available";
            }

            string sampleJob = idField + employeeNameField + employerNameField + jobLocationField + positionField + competencyField;
            return sampleJob;
        }




    }
}
