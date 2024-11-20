namespace Sem3_Laba2.Mammals
{
    public class Mammal : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Walk");
        }
        public override string ToString()
        {
            return base.ToString() + "\nSubclass: Mammal";
        }

    }
}
