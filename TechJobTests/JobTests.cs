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

            Assert.IsTrue(testJob.ToString().StartsWith("\n"));
            Assert.IsTrue(testJob.ToString().EndsWith("\n"));

        }

        [TestMethod]

        public void TestJobsForLabel() //Concentrate on the label part here...making sure the labels line up correctly with each specific item in testJob
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string result = $"\n ID: {testJob.Id} \n Name: Product tester \n Employer: ACME \n Location: Desert \n Position Type: Quality control \n Core Competency: Persistence \n";

            Assert.AreEqual(result, testJob.ToString());

        }

        [TestMethod]
        
        public void TestJobsForNull()
        {
            Job testJob = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            string result = $"\n ID: {testJob.Id} \n Name: Data not available \n Employer: Data not available \n Location: Data not available \n Position Type: Data not available \n Core Competency: Data not available \n";

            Assert.AreEqual(result, testJob.ToString());
        }
    }
}
