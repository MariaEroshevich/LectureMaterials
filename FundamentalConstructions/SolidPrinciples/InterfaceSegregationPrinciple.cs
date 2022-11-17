namespace SolidPrinciples
{
    public interface IEmployee
    {
        void Work();
        void Eat();
    }

    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();
    }


    public class Human : IWorkable, IFeedable
    {
        public void Work()
        {
            // ....working
        }

        public void Eat()
        {
            // ...... eating in lunch break
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            //.... working much more
        }
    }
}