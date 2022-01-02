using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests //test
    {
        Job jobThree;
        
        [TestInitialize]
        public void TestJobExample()
        {
            jobThree = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        }
        [TestMethod]
        public void TestSettingJobId()//test each job is assigned an id and that it unique to each job
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();
            Assert.IsFalse(jobOne.Equals(jobTwo));
            Assert.IsTrue(jobOne.Id != jobTwo.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()//test that all fields are assigned a value
        {
            
            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality Control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job jobOne = new Job("Product Tester", acme, desert, qualityControl, persistence);


            Assert.IsTrue("Product Tester" == jobOne.Name);
            Assert.AreEqual("ACME", jobOne.EmployerName.Value);
            Assert.AreEqual("Desert", jobOne.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", jobOne.JobType.Value);
            Assert.AreEqual("Persistence", jobOne.JobCoreCompetency.ToString());//?
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality Control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job jobOne = new Job("Product Tester", acme, desert, qualityControl, persistence);
            Job jobTwo = new Job("Product Tester", acme, desert, qualityControl, persistence);

            Assert.IsFalse(jobOne.Equals(jobTwo));
        }
        [TestMethod]
        public void TestToStringBlankLines()//added ToString method in Job.cs to test
        {
            string testJob = $"\nID: { jobThree.Id}\nName: {jobThree.Name}\nEmployer: {jobThree.EmployerName}\n" +
                $"Location: {jobThree.EmployerLocation}\nPosition Type: {jobThree.JobType}\n" +
                $"Core Competency: {jobThree.JobCoreCompetency}\n";

            Assert.AreEqual(testJob, jobThree.ToString());
        }
        [TestMethod]
        public void TestForLabelAndDataForEachStringOnSeperateLine()//added ToString method in Job.cs to test
        {
            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality Control");
            CoreCompetency persistence = new CoreCompetency("Persistence");
                     
            Job job = new Job("Product tester", acme, desert, qualityControl, persistence);                     
            Assert.AreEqual("\nID: 2\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality Control\nCore Competency: Persistence\n", job.ToString());
        }
        [TestMethod]
        public void TestToStringForEmptyDataFields()//added ToString method in Job.cs to test
        {
            Job job = new Job();
            string testJob = $"\nID: 13\nName: Data not available\nEmployer: Data not available\n" +
                $"Location: Data not available\nPosition Type: Data not available\n" +
                $"Core Competency: Data not available\n";
            Assert.AreEqual(testJob, job.ToString());
        }

    }
}
