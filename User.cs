using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	
	class User
	{

		private static string name;
		public static void setUser(string name2)
		{
			name = name2;
		}

		public static string getUser()
		{
			return name;
		}
	}

	
}
