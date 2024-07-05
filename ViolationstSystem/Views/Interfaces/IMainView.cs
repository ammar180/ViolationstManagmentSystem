using System;
using System.Windows.Forms;

namespace ViolationsSystem.Views.Interfaces
{
	public interface IMainView
	{
		event EventHandler ShowView;

		Panel Container { get; }
	}
}
