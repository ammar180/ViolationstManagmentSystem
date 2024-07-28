using DocumentFormat.OpenXml.Office2010.ExcelAc;
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
	public partial class FilterUserControle : UserControl
	{
        public List<string> FilterList
		{
			get
			{
				var list = CodeCheckedList.CheckedItems.Cast<string>().ToList();
				list.AddRange(UnitsFilter);
				return list;
			}
			set
			{
				CodeCheckedList.Items.Clear();
				value.ForEach(x => CodeCheckedList.Items.Add(x, true));
			}
		}
        public List<string> UnitsFilter
		{
			get
			{
				return UnitsCheckedList.CheckedItems.Cast<string>().ToList();
			}
		}
        public FilterUserControle()
		{
			InitializeComponent();
			checkBoxSelectAllUnits.Checked = true;
		}

		private void checkBoxSelectAllCars_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < CodeCheckedList.Items.Count; i++)
				CodeCheckedList.SetItemChecked(i, checkBoxSelectAllCars.Checked);
		}

		private void checkBoxSelectAllUnits_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < UnitsCheckedList.Items.Count; i++)
				UnitsCheckedList.SetItemChecked(i, checkBoxSelectAllUnits.Checked);
		}
	}
}
