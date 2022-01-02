using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
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

    }
}
