using System;

namespace LSP
{

    // Base class is subsitutable for
    // a more derived class
    public abstract class Bird
    {

    }

    public class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            // Implementation goes here
        }
    }

    public class WalkingBird : Bird
    {
        public virtual void Walk()
        {
            // Implementation goes here
        }
    }

    public class SwimmingBird : Bird
    {
        public virtual void Swim()
        {
            // Implementation goes here
        }
    }


    public class Eagle : FlyingBird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle flying");
        }
    }

    public class Ostrich : WalkingBird
    {
        public override void Walk()
        {
            Console.WriteLine("Ostrich walking");
        }
    }

    public class Duck : SwimmingBird
    {
        public override void Swim()
        {
            Console.WriteLine("Duck floating");
        }
    }
}
