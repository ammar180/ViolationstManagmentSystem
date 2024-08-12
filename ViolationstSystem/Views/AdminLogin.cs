using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationsCollecting.View.CustomeComponants;
using ViolationSystem.Data.Entities;
using ViolationSystem.Data.Repositories;

namespace ViolationstSystem.Views
{
	public partial class AdminLogin : UserControl
	{
		public static bool IsAdmin { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		private IRepository repository;
		private LoadingForm loading = new LoadingForm();
		public List<string> Units
		{
			get
			{
				return UnitsCheckedList.CheckedItems.Cast<string>().ToList();
			}
		}
		public AdminLogin()
		{
			InitializeComponent();
			repository = new Repository(Properties.Settings.Default.SelectedConnectionType);
			IsAdmin = false;
			checkBoxSelectAllUnits.Checked = true;
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				string message = "";
				if (btnLogin.Text == "دخول")
				{
					UserName = txtUserName.Text;
					Password = txtPassword.Text;
					if (await repository.ValidateIsAdmin(UserName, Password))
					{
						IsAdmin = true;
						btnLogin.Text = "تحديث";
						message = "تسجيل دخول ناجح";
					}
					else
						message = "اسم المشرف او كلمة السر غير صحيح";

				}
				else if (btnLogin.Text == "تحديث")
				{
					message = await repository.UpdateAdminNamePassword(UserName, Password, txtUserName.Text, txtPassword.Text) ?
						"تم تحديث اسم المشرف وكلمة السر بنجاح" + "\n" + $"اسم المشرف: {txtUserName.Text}" + "\n" + $"كلمة السر: {txtPassword.Text}" :
						"تعذر التحديث للاسف";

				}
				MessageBox.Show(message,
					"اعلام بالحالة",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
					"اعلام بالحالة",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);
			}
		}

		
		private void checkBoxSelectAllUnits_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < UnitsCheckedList.Items.Count; i++)
				UnitsCheckedList.SetItemChecked(i, checkBoxSelectAllUnits.Checked);
		}

		private async void btnExplore_Click(object sender, EventArgs e)
		{
			loading.Show();
			DateTime? VdateStart = null;
			DateTime? VdateEnd = null;
			DateTime? PydateStart = null;
			DateTime? PydateEnd = null;
			if (checkViolationDate.Checked)
			{
				VdateStart = new DateTime(2000 + (int)VYearS.Value, (int)VMonS.Value, 1);
				VdateEnd = new DateTime(2000 + (int)VYearE.Value, (int)VMonE.Value, DateTime.DaysInMonth(2000 + (int)VYearE.Value, (int)VMonE.Value));
			}
			if (checkPaymentDate.Checked)
			{
				PydateStart = new DateTime(2000 + (int)PyYearS.Value, (int)PyMonS.Value, 1);
				PydateEnd  = new DateTime(2000 + (int)PyYearE.Value, (int)PyMonE.Value, DateTime.DaysInMonth(2000 + (int)PyYearE.Value, (int)PyMonE.Value));
			}
			var list =  await repository.ViolationReport(Units, VdateStart, VdateEnd, PydateStart, PydateEnd);
			ReportDataSource rs = new ReportDataSource();
			var helperForm = HelperForm.GetInstance();
			rs.Name = "TruckViolationsDataSet";
			rs.Value = list.Take(200);
			helperForm.reportViewer.LocalReport.ReportEmbeddedResource = "ViolationstSystem.Reports.ExploreAdminReport.rdlc";
			helperForm.reportViewer.LocalReport.DataSources.Clear();
			helperForm.reportViewer.LocalReport.DataSources.Add(rs);

			helperForm.reportViewer.LocalReport.SetParameters(
				new ReportParameter("ListOfUnitsParameter", string.Join(" - ", Units.ToArray()))
				);
			string Parameter1Message = (checkViolationDate.Checked) ? $"تاريخ المخالفة في الفترة من" +
					$" {VdateStart:d/M/yyyy} " +
					$"إلى" +
					$" {VdateEnd:d/M/yyyy} " : " ";
			helperForm.reportViewer.LocalReport.SetParameters(
				new ReportParameter("ViolationDateRangeParameter", Parameter1Message)
				);
			string Parameter2Message = (checkPaymentDate.Checked) ? $"تاريخ السداد في الفترة من" +
					$" {PydateStart:d/M/yyyy} " +
					$"إلى" +
					$" {PydateEnd:d/M/yyyy} " : " ";
			helperForm.reportViewer.LocalReport.SetParameters(
				new ReportParameter("PymentDateRangeParameter", Parameter2Message)
				);
			helperForm.reportViewer.LocalReport.SetParameters(new ReportParameter("TotalResultParameter", list.Count().ToString()));
			loading.Hide();
			helperForm.ShowDialog();
		}

		private void checkPaymentDate_CheckedChanged(object sender, EventArgs e)
		{
			PyflowLayout.Enabled = checkPaymentDate.Checked;
		}

		private void checkViolationDate_CheckedChanged(object sender, EventArgs e)
		{
			VflowLayout.Enabled = checkViolationDate.Checked;
		}
	}
}
