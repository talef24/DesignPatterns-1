using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
	public partial class LoginForm : Form
	{
		private readonly AppManager r_AppManager = new AppManager();

		public LoginForm()
		{
			InitializeComponent();
			checkIfAskedToBeRemember();
		}

		private void checkIfAskedToBeRemember()
		{
			string lastAccessToken = r_AppManager.AppSettings.LastAccessToken;
			if (r_AppManager.AppSettings.RememberUser && !string.IsNullOrEmpty(lastAccessToken))
			{
				r_AppManager.LoginResult = FacebookService.Connect(lastAccessToken);
				r_AppManager.Init();
				checkLogin();
			}
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			r_AppManager.Login();
			checkLogin();
		}

		private void checkLogin()
		{
			if (!r_AppManager.IsAccessTokenNull())
			{
				showMainForm();
			}
			else
			{
				MessageBox.Show(r_AppManager.LoginResult.ErrorMessage);
			}
		}

		private void showMainForm()
		{
			MainForm mainForm = new MainForm(r_AppManager);
			this.Hide();
			mainForm.ShowDialog();
		}
	}
}