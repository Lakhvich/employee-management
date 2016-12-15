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
using DataProvider.Entities;
using Presentation.Presenters;
using DataProvider.Concrete;
using DataProvider.Abstract;
using System.ComponentModel.DataAnnotations;

namespace UI
{
    public partial class EmployeesForm : Form, IEmployeesView
    {
        private EmployeesPresenter presenter;

        public EmployeesForm()
        {
            InitializeComponent();
            presenter = new EmployeesPresenter(this, new EmployeeRepository());
            presenter.LoadEmployees();
        }

        public void SetEmployees(IEnumerable<Employee> employee)
        {
            ClearGrid();
            foreach (var emp in employee)
            {
                AddEmployeeToGrid(emp);
            }   
        }

        public void ClearGrid()
        {
            listEmployees.Columns.Clear();
            listEmployees.Columns.Add("Id", 30, HorizontalAlignment.Left);
            listEmployees.Columns.Add("Имя", 100, HorizontalAlignment.Left);
            listEmployees.Columns.Add("Фамилия", 100, HorizontalAlignment.Left);
            listEmployees.Columns.Add("Дата рождения", 100, HorizontalAlignment.Left);
            listEmployees.Columns.Add("Должность", 100, HorizontalAlignment.Left);
            listEmployees.Columns.Add("Зарплата", 100, HorizontalAlignment.Right);
            listEmployees.Items.Clear();
        }

        public void AddEmployeeToGrid(Employee emp)
        {
            ListViewItem parent;
            parent = listEmployees.Items.Add(emp.EmployeeID.ToString());
            parent.SubItems.Add(emp.FirstName);
            parent.SubItems.Add(emp.LastName);
            parent.SubItems.Add(emp.DateOfBirth.ToShortDateString());
            parent.SubItems.Add(emp.Position);
            parent.SubItems.Add(emp.Salary.ToString("f"));
        }

        public List<ValidationResult> InsertEmployee(Employee emp)
        {
            return presenter.Create(emp);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
