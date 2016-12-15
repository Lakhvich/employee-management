using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface IEmployeesView
    {
        void SetEmployees(IEnumerable<Employee> employee);
        void AddEmployeeToGrid(Employee employee);
        void DeleteEmployeeFromGrid(int id);
        void DeleteEmployeeFromGrid(Employee employee);
    }
}
