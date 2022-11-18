using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;

        private IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employeeReport = new EmployeeReport();
            _employees = employees;
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"Employee report on date {DateTime.Now}";
            return this;
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body = String.Join(Environment.NewLine, _employees.Select(x => $"\nEmployee: {x.Name} Salary: {x.Salary}"));
            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer = $"\nTotal employees: {_employees.Count()} Total salary: {_employees.Sum(x => x.Salary)}";
            return this;
        }

        public EmployeeReport GetReport()
        {
            return _employeeReport;
        }
    }
}
