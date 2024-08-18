using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolationstSystem.Views.CustomeComponants
{
	public partial class GetNameUC : Form
	{
		private static GetNameUC instance;
		public GetNameUC()
		{
			InitializeComponent();
		}
		public static GetNameUC Instance()
		{
			return instance ?? (instance = new GetNameUC());
		}

	}
}
