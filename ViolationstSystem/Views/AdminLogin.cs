using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationSystem.Data.Repositories;

namespace ViolationstSystem.Views
{
	public partial class AdminLogin : UserControl
	{
		public static bool IsAdmin { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public static AdminLogin instance { get; set; }
		public AdminLogin()
		{
			InitializeComponent();
			IsAdmin = false;
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{

				IRepository repository = Repository.GetInstance();
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
		public static AdminLogin GetInstance()
		{
			if (instance == null)
				instance = new AdminLogin();
			return instance;
		}
	}
}
