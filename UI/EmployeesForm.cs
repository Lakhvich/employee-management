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
        private DataTable dataTable;
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
            dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("DateOfBirth");
            dataTable.Columns.Add("Position");
            dataTable.Columns.Add("Salary");

            foreach (var empl in employee)
                AddEmployeeToDataTable(empl);
        }

        public void AddEmployeeToDataTable(Employee employee)
        {
            DataRow row = dataTable.NewRow();
            row["Id"] = employee.EmployeeID.ToString();
            row["FirstName"] = employee.FirstName;
            row["LastName"] = employee.LastName;
            row["DateOfBirth"] = employee.DateOfBirth.ToShortDateString();
            row["Position"] = employee.Position;
            row["Salary"] = employee.Salary.ToString("f");
            dataTable.Rows.Add(row);
            AddEmployeeToGrid(row);
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
        }

        public void AddEmployeeToGrid(DataRow row)
        {
            ListViewItem item = new ListViewItem(row["Id"].ToString());
            item.SubItems.Add(row["FirstName"].ToString());
            item.SubItems.Add(row["LastName"].ToString());
            item.SubItems.Add(row["DateOfBirth"].ToString());
            item.SubItems.Add(row["Position"].ToString());
            item.SubItems.Add(row["Salary"].ToString());
            listEmployees.Items.Add(item);
        }

        public List<ValidationResult> InsertEmployee(Employee empl)
        {
            return presenter.Create(empl);
        }

        public void DeleteEmployeeFromGrid(Employee empl)
        {
            foreach (ListViewItem row in listEmployees.Items)
                if (row.Text == empl.EmployeeID.ToString())
                    row.Remove();

            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
                if (dataTable.Rows[i]["Id"].ToString() == empl.EmployeeID.ToString())
                    dataTable.Rows[i].Delete();
        }

        public void DeleteEmployeeFromGrid(int id)
        {
            foreach (ListViewItem row in this.listEmployees.Items)
                if (row.Text == id.ToString())
                    row.Remove();

            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
                if (dataTable.Rows[i]["Id"].ToString() == id.ToString())
                    dataTable.Rows[i].Delete();
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

        private void txtPositionFilter_TextChanged(object sender, EventArgs e)
        {
            listEmployees.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
                if (row["Position"].ToString().StartsWith(txtPositionFilter.Text))
                    AddEmployeeToGrid(row);
        }
    }
}
