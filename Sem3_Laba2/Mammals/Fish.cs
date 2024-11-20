namespace Sem3_Laba2.Mammals
{
    public class Fish : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("Swim");
        }
        public override string ToString()
        {
            return base.ToString() + "\nSubclass: Fish";
        }
    }
}
