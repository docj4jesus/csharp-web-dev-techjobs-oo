using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]

        public void TestSettingJobID()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            bool result = (job1.Id == job2.Id);

            Assert.IsFalse(result);
        }

        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(testJob.Name, "Product tester");
            Assert.AreEqual(testJob.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob.JobType.Value, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency.Value, "Persistence");

        }

        [TestMethod]

        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            bool result = (job1 == job2);

            Assert.AreEqual(result, false);
        }

        [TestMethod]

        public void TestJobsForBlankLine()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual

        }

        [TestMethod]

        public void TestJobsForLabel()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        
        public void TestJobsForNull()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }
    }
}
