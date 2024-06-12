
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
    Job job1 = new Job();
    Job job2 = new Job();
    Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

    [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.AreEqual(job1.Id+1, job2.Id);
        }

    [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

    [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

    [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.AreEqual(job4.ToString().Substring(0,1), "\n");
            Assert.AreEqual(job4.ToString().Substring(job4.ToString().Length - 1), "\n");
        }

    [TestMethod]
    public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(job4.ToString().Substring(1, job4.ToString().Length - 2), $"ID: {job4.Id}\nName: {job4.Name}\nEmployer: {job4.EmployerName}\nLocation: {job4.EmployerLocation}\nPosition Type: {job4.JobType}\nCore Competency: {job4.JobCoreCompetency}");
        }

    [TestMethod]
    public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(job1.ToString().Substring(1, job1.ToString().Length - 2), $"ID: {job1.Id}\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available");
        }
    }
}

