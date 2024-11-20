namespace Sem3_Laba2.Mammals
{
    public class Crocodile : Fish
    {
        public override void Move()
        {
            base.Move();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString() + "\nType: Crocodile";
        }
    }
}
