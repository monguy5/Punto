using System;
namespace Punto { 
public class LoginModel
{
        private string _Usuario;
        private string _Password;
	public LoginModel()
	{
	}

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
    }
}