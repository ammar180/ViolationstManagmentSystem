using System;
using System.Windows.Forms;

namespace ViolationsSystem.Views.Interfaces
{
	public interface IHomeView
	{
        BindingSource HomeViewBS { get; set; }
        event EventHandler HandleGridEdit;
        event EventHandler HandleGridAdd;

    }
}
