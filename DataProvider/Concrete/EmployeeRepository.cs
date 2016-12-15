using DataProvider.Abstract;
using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Concrete
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public IEnumerable<Employee> GetAll
        {
            get
            {
                using (StaffContext db = new StaffContext())
                {
                    return db.Employees.ToList();
                }
            }
        }

        public void Create(Employee employee)
        {
            using (StaffContext db = new StaffContext())
            {
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
        }

        public Employee Get(int id)
        {
            using (StaffContext db = new StaffContext())
            {
                return (from c in db.Employees
                        where c.EmployeeID == id
                        select c).FirstOrDefault();
            }
        }

        public void Update(Employee employee)
        {
            using (StaffContext db = new StaffContext())
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
        }

        public void Delete(Employee employee)
        {
            using (StaffContext db = new StaffContext())
            {
                Employee empl = (from c in db.Employees
                                 where c.EmployeeID == employee.EmployeeID
                                 select c).FirstOrDefault();

                db.Employees.DeleteOnSubmit(empl);
                db.SubmitChanges();
            }
        }
    }
}
