using Sem3_Laba2.Animals;

namespace Sem3_Laba2.Mammals
{
    public class Bird : Animal, IFlyable
    {
        IFlyable behavior = new FlyWithWings();

        public void Fly()
        {
            behavior.Fly();
        }

        public override string ToString()
        {
            return base.ToString() + "\nSubclass: Bird";
        }
    }
}
