using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Concrete
{
    public class StaffContext : DataContext
    {
        public StaffContext() : base(Properties.Settings.Default.StaffDBConnectionString ) { }
        public Table<Employee> Employees;
    }
}
