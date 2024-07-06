﻿
using System;
using System.Linq;
using System.Windows.Forms;
using ViolationsSystem.Data.Oprations;
using ViolationsSystem.Data.Repositories;
using ViolationsSystem.Views;
using ViolationsSystem.Views.Interfaces;

namespace ViolationsSystem.Presenter
{
	public class MainPresenter
	{
		private IMainView view;
		public MainPresenter(IMainView view)
	    {
			this.view = view;

			this.view.ShowView += SetView;


			LoadPresenters();
		}

		

		private void LoadPresenters()
		{
			new HomePresenter(HomeView.GetInstance(), Repository.GetInstance());
			new SendTrafficPresenter(SendTrafficView.GetInstance(), Repository.GetInstance());
		}

		//Methods
		private void SetView(object sender, EventArgs e)
		{

			UserControl userControl = (UserControl)sender;
			// show view
			var oldPage = view.Container.Controls.OfType<UserControl>().FirstOrDefault();

			if (oldPage != null && oldPage != userControl)
				view.Container.Controls.Remove(oldPage);

			if (oldPage != userControl)
			{
				userControl.Dock = DockStyle.Fill;
				view.Container.Controls.Add(userControl);
			}

		}
	}
}