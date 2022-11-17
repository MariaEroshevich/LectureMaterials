
namespace SolidPrinciples
{
    public class Report
    {
        public string Text { get; set; } = "";
        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine($"Переход к странице {pageNumber}");
        }
    }

    public class Printer
    {
        public void Print(Report report)
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(report.Text);
        }
    }

}
