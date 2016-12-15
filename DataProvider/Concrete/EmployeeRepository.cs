using DataProvider.Abstract;
using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Concrete
{
    public class EmployeeRepository : IDisposable, IRepository<Employee>
    {
        private StaffContext db = new StaffContext();

        public IEnumerable<Employee> GetAll => db.Employees;

        public void Create(Employee employee)
        {
            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();
        }

        public Employee Get(int id)
        {
            return (from c in db.Employees
                    where c.EmployeeID == id
                    select c).FirstOrDefault();
        }

        public void Update(Employee employee)
        {
            Employee emp = (from c in db.Employees
                            where c.EmployeeID == employee.EmployeeID
                            select c).FirstOrDefault();

            if (emp != null)
            {
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Position = employee.Position;
                emp.Salary = employee.Salary;
                emp.DateOfBirth = employee.DateOfBirth;
            }
            db.SubmitChanges();
        }

        public void Delete(Employee employee)
        {
            db.Employees.DeleteOnSubmit(employee);
            db.SubmitChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
