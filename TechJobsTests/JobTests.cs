using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job jobThree;
        Job jobFour;
        [TestInitialize]
        public void TestJobExample()
        {
            jobThree = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            jobFour = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();
            Assert.IsFalse(jobOne.Equals(jobTwo));
            Assert.IsTrue(jobOne.Id != jobTwo.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            
            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality Control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job jobOne = new Job("Product Tester", acme, desert, qualityControl, persistence);


            Assert.IsTrue("Product Tester" == jobOne.Name);
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
                $"Core Compentency: {jobThree.JobCoreCompetency}\n";

            Assert.AreEqual(testJob, jobThree.ToString());
        }
        [TestMethod]
        public void TestToStringForEmptyDataFields()
        {
            //Job job = new Job();
            string testJob = $"\nID: {jobFour.Id}\nName: {jobFour.Name}\nEmployer: {jobFour.EmployerName}\n" +
                $"Location: {jobFour.EmployerLocation}\nPosition Type: {jobFour.JobType}\n" +
                $"Core Compentency: {jobFour.JobCoreCompetency}\n";
            Assert.AreEqual(testJob, jobFour.ToString());
        }

    }
}
