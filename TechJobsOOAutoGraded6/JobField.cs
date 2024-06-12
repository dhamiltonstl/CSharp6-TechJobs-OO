namespace TechJobsOOAutoGraded6;

public class JobField
{
   public int Id { get; }
   private static int nextId = 1;

   public JobField()
   {
      Id = nextId++;
      nextId++;
   }

   public override bool Equals(object obj)
   {
      return obj is Employer employer &&
            Id == employer.Id;
   }

   public override int GetHashCode()
   {
      return HashCode.Combine(Id);
   }

}
