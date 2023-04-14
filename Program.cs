using System.Net.Security;

namespace AbstractkTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eagle eagle = new Eagle();
            //eagle.Fly();
            //eagle.Eat();
            //eagle.See();

            //Shark shark = new Shark();
            //shark.Swim();
            //shark.Eat();
            //shark.See();

            Animals eagle = new Eagle();
            Animals shark = new Shark();
            Animals[] animals = new Animals[] {eagle, shark};
            foreach (var animal in animals)
            {
                animal.Eat();
                animal.See();
            }
        }
    }
    abstract class Animals
    {
        public Animals()
        {
            Console.WriteLine("hello");
        }
        public abstract void Eat();
        public virtual void See()
        {
            Console.WriteLine("See as Animals");
        }
        

        public int MyProperty { get; set; }
    }

    abstract class Fish :Animals
    {
        public abstract void Swim();
    }



    abstract class Bird : Animals
    {
        public abstract void Fly();
    }
    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    
    }
    class Shark :Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }


        public override void See()
        {
            Console.WriteLine("See as Shark");
        }
    }
}