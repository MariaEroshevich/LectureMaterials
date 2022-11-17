using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public  class EmployeeReportDirector
    {
        private IEmployeeReportBuilder _builder;

        public EmployeeReportDirector(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildHeader().BuildBody().BuildFooter();
        }
    }
}
