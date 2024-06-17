
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
            Assert.AreEqual(job1.Id+2, job2.Id);
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
            Console.WriteLine("ALERT: " + job4.ToString().Substring(0,3));
            Assert.IsTrue(job4.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job4.ToString().EndsWith(Environment.NewLine));
        }

    [TestMethod]
    public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(job4.ToString(), $"{Environment.NewLine}ID: {job4.Id}{Environment.NewLine}Name: {job4.Name}{Environment.NewLine}Employer: {job4.EmployerName}{Environment.NewLine}Location: {job4.EmployerLocation}{Environment.NewLine}Position Type: {job4.JobType}{Environment.NewLine}Core Competency: {job4.JobCoreCompetency}{Environment.NewLine}");
        }

    [TestMethod]
    public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(job1.ToString(), $"{Environment.NewLine}ID: {job1.Id}{Environment.NewLine}Name: Data not available{Environment.NewLine}Employer: Data not available{Environment.NewLine}Location: Data not available{Environment.NewLine}Position Type: Data not available{Environment.NewLine}Core Competency: Data not available{Environment.NewLine}");
        }
    }
}

