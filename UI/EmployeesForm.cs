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

        public void AddEmployeeToGrid(Employee empl)
        {
            ListViewItem parent;
            parent = listEmployees.Items.Add(empl.EmployeeID.ToString());
            parent.SubItems.Add(empl.FirstName);
            parent.SubItems.Add(empl.LastName);
            parent.SubItems.Add(empl.DateOfBirth.ToShortDateString());
            parent.SubItems.Add(empl.Position);
            parent.SubItems.Add(empl.Salary.ToString("f"));
        }

        public List<ValidationResult> InsertEmployee(Employee empl)
        {
            return presenter.Create(empl);
        }

        public void DeleteEmployeeFromGrid(Employee empl)
        {
            foreach (ListViewItem row in this.listEmployees.Items)
                if (row.Text == empl.EmployeeID.ToString())
                    row.Remove();
        }

        public void DeleteEmployeeFromGrid(int id)
        {
            foreach (ListViewItem row in this.listEmployees.Items)
                if (row.Text == id.ToString())
                    row.Remove();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listEmployees.SelectedItems.Count > 0)
                presenter.Delete(int.Parse(listEmployees.SelectedItems[0].Text));
        }
    }
}
