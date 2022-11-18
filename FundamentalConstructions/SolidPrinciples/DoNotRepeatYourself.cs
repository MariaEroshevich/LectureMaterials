
namespace SolidPrinciples
{
    public class DoNotRepeatYourself
    {
        public List<DeveloperData> ShowDeveloperList(Developers developers)
        {
            foreach (var developers in developer)
            {
                var expectedSalary = developer.CalculateExpectedSalary();
                var experience = developer.GetExperience();
                var githubLink = developer.GetGithubLink();
                var data = new[] {
            expectedSalary,
            experience,
            githubLink
        };

                Render(data);
            }
        }

        public List<ManagerData> ShowManagerList(Manager managers)
        {
            foreach (var manager in managers)
            {
                var expectedSalary = manager.CalculateExpectedSalary();
                var experience = manager.GetExperience();
                var githubLink = manager.GetGithubLink();
                var data =
                new[] {
            expectedSalary,
            experience,
            githubLink
                };

                Render(data);
            }
        }

        public List<EmployeeData> ShowList(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                var expectedSalary = employee.CalculateExpectedSalary();
                var experience = employee.GetExperience();
                var githubLink = employee.GetGithubLink();
                var data =
                new[] {
            expectedSalary,
            experience,
            githubLink
                };

                Render(data);
            }
        }
    }
}
