using Builder;

List<Employee> employee = new List<Employee>
{ 
    new Employee{Name = "Ivan", Salary = 100 },
    new Employee{Name = "Vasya", Salary = 70},
    new Employee{Name = "Olya", Salary = 120}
};

EmployeeReportBuilder builder = new EmployeeReportBuilder(employee);
EmployeeReportDirector director = new EmployeeReportDirector(builder);
director.Build();
Console.WriteLine(builder.GetReport().ToString());

