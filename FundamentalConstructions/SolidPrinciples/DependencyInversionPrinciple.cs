namespace SolidPrinciples
{
    public abstract class EmployeeBase
    {
        public virtual void Work()
        {
            // ....working
        }
    }

    public class Human : EmployeeBase
    {
        public override void Work()
        {
            //.... working much more
        }
    }

    public class Robot : EmployeeBase
    {
        public override void Work()
        {
            //.... working much, much more
        }
    }

    public class Manager
    {
        private List<EmployeeBase> _employees;

        public Manager(List<EmployeeBase> employees)
        {
            _employees = employees;
        }

        public void Manage()
        {
            foreach(var e in _employees)
            {
                e.Work();
            }
        }
    }
}