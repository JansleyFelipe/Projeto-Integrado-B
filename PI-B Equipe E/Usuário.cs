using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_B_Equipe_E
{
    static class Usuário
    {
        private static bool loged;

        private static string permission_level;
               
        private static string email;
               
        private static string nome;

        private static string login;

        private static DateTime aniversario;

        public static bool Loged
        {
            set
            {
                loged = value;
            }
            get
            {
                return loged;
            }
        }

        public static string PermissioLevel
        {
            set
            {
                permission_level = value;
            }
            get
            {
                return permission_level;
            }
        }

        public static string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }

        public static string Nome
        {
            set
            {
                nome = value;
            }
            get
            {
                return nome;
            }
        }

        public static string Login
        {
            set
            {
                login = value;
            }
            get
            {
                return login;
            }
        }

        public static DateTime Aniversario
        {
            set
            {
                aniversario = value;
            }
            get
            {
                return aniversario;
            }
        }

        public static void Logoff()
        {
            Loged = false;
            PermissioLevel = null;
            Email = null;
            Nome = null;
            Login = null;
            aniversario = DateTime.Now;
        }
}
}
