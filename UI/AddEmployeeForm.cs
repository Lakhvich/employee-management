using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Employee empl = new Employee()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = dateDateOfBirth.Value,
                    Position = txtPosition.Text,
                    Salary = decimal.Parse(txtSalary.Text)
                };

                List<ValidationResult> stateError = (this.Owner as EmployeesForm).InsertEmployee(empl);

                if (stateError.Count > 0)
                {
                    foreach(var err in stateError)
                    {
                        string boxName = "txt" + err.MemberNames.First();
                        if (grpDetails.Controls.ContainsKey(boxName))
                            errorProvider.SetError(grpDetails.Controls[boxName], err.ErrorMessage);
                    }  
                }
                else
                {
                    this.Close();
                } 
            }
        }

        private bool ValidateForm()
        {
            bool IsTextBoxValid = true;
            errorProvider.Clear();
            foreach (var textBox in grpDetails.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider.SetError(textBox, "Поле не может быть пустым.");
                    IsTextBoxValid = false;
                    textBox.Focus();
                }
            }   
            return IsTextBoxValid;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 44)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char) 44)
            {
                if (txtBox.Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
            if (txtBox.Text.IndexOf((char) 44) != -1 && e.KeyChar != (char)Keys.Back)
            {
                int index = txtBox.Text.IndexOf((char) 44);
                if (index + 2 < txtBox.Text.Length && txtBox.SelectionStart > index)
                    e.Handled = true;
            }
        }
    }
}
