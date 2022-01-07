using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program //prints out list of Job objects.  Not my code
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer();
            Location location = new Location();
            PositionType positionType = new PositionType();
            CoreCompetency coreCompetency = new CoreCompetency();
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Job job4 = new Job("", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Job job5 = new Job("Ice cream tester",employer, location, positionType, coreCompetency);//Test for null arguments


            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);
            jobs.Add(job5);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            
        }
    }
}
