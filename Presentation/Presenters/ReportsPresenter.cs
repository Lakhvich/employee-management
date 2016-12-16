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
    public class ReportsPresenter
    {
        private readonly IReportsView view;
        private readonly IRepository<Employee> model;

        public ReportsPresenter(IReportsView view, IRepository<Employee> model)
        {
            this.view = view;
            this.model = model;
        }

        public IEnumerable<Employee> GetData()
        {
            return model.GetAll;
        }
    }
}
