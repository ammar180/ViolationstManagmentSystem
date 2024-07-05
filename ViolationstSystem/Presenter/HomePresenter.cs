
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ViolationsSystem.Data.Repositories;
using ViolationsSystem.Views;
using ViolationsSystem.Views.Interfaces;
using ViolationSystem.Data.Entities;

namespace ViolationsSystem.Presenter
{
	public class HomePresenter
	{
		private IHomeView view;
		private IRepository repository;
		private BindingSource violationsBindingSource;
		private ICollection<Violation> violationsList;

		public HomePresenter(IHomeView view, IRepository repository)
	    {
			this.violationsBindingSource = new BindingSource();
			this.view = view;
			this.repository = repository;
			LoadAllViolationsList();
		}
		//Methods
		private void LoadAllViolationsList()
		{
			if (repository.IsCanConnect())
			{
				violationsList = repository.GetAllViolations();
				this.view.HomeViewBS.DataSource = violationsList;

            }
            else
				MessageBox.Show("قاعدة البيانات ليست متصله");
		}
	}
}
