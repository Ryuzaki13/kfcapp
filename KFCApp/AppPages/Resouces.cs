using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFCApp.AppPages
{
	public static class Resouces
	{
		private static Authorization authorization;
		private static RegistrationSuperUser registrationSuperUser;

		public static Authorization GetAuthorization()
		{
			if (authorization == null)
			{
				authorization = new Authorization();
			}

			return authorization;
		}

		public static RegistrationSuperUser GetRegistrationSuperUser()
		{
			if (registrationSuperUser == null)
			{
				registrationSuperUser = new RegistrationSuperUser();
			}

			return registrationSuperUser;
		}
	}
}
