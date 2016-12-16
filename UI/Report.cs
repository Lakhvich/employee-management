using DataProvider.Concrete;
using DataProvider.Entities;
using Microsoft.Reporting.WinForms;
using Presentation.Presenters;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Report : Form, IReportsView
    {
        private ReportsPresenter presenter;

        public Report()
        {
            InitializeComponent();
            presenter = new ReportsPresenter(this, new EmployeeRepository());
        }

        private void Report_Load(object sender, EventArgs e)
        {
            IEnumerable<Employee> workforceThree = presenter.GetData();
            ReportDataSource datasource = new ReportDataSource("AverageSalaryEmployeeReport", workforceThree);
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(datasource);
            rptViewer.RefreshReport();
        }

        public void SetReports()
        {
            throw new NotImplementedException();
        }
    }
}
