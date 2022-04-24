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
using System.Security.Cryptography;

namespace KFCApp.AppPages
{

	public partial class RegistrationSuperUser : Page
	{
		// Save pointer to database context
		private readonly AppData.AppConnector ConnectorPtr;

		private readonly AppData.Role RoleName = AppData.Role.SuperUser;

		public RegistrationSuperUser()
		{
			InitializeComponent();

			ConnectorPtr = Lib.Connector.GetModel();
		}

		private void RegistrationClick(object sender, RoutedEventArgs ev)
		{
			string phone = Login.Text.Trim();
			string password = Password.Password.Trim();
			if (phone.Length != 10)
			{
				MessageBox.Show("Длина логина должна составлять 10 символов (номер телефона)");
				return;
			}
			if (password.Length < 6 || password.Length > 20)
			{
				MessageBox.Show("Длина пароля должна лежать в диапазоне 6..20 символов");
				return;
			}

			AppData.Employee employee = new AppData.Employee();
			employee.Phone = phone;
			employee.Password = password;
			employee.Role = RoleName;

			ConnectorPtr.Employees.Add(employee);
			int result = ConnectorPtr.SaveChanges();
			if (result == 0)
			{
				MessageBox.Show("Регистрация не была выполнена");
				return;
			}

			NavigationService.Navigate(Resouces.GetAuthorization());
		}

	}
}
