
using System;
using System.Windows.Forms;

namespace ViolationsSystem.Views.Interfaces
{
	public interface IManageDataView
	{
		BindingSource HomeViewBS { get; }
		event EventHandler HandleImport;
	}
}
