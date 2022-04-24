using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KFCApp.AppPages
{
	public partial class Authorization : Page
	{
		public Authorization()
		{
			InitializeComponent();
		}

		private void OnLogin(object sender, RoutedEventArgs e)
		{
			if (Lib.Connector.Authorize(Phone.Text, Password.Password) == true)
			{
				MessageBox.Show("Привет");

				var profile = Lib.Connector.GetMyProfile();

				
			}
			else
			{
				MessageBox.Show("Неверный логин");
			}
		}
	}
}
