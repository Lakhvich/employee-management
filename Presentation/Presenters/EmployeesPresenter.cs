using DataProvider.Abstract;
using DataProvider.Entities;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class EmployeesPresenter
    {
        private readonly IEmployeesView view;
        private readonly IRepository<Employee> model;

        public EmployeesPresenter(IEmployeesView view, IRepository<Employee> model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadEmployees()
        {
            var employees = model.GetAll;
            view.SetEmployees(employees);
        }
    }
}
