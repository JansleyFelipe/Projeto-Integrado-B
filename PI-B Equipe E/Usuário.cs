using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_B_Equipe_E
{
    static class Usuário
    {
        private static bool logado;

        private static string permissao;
               
        private static string email;
               
        private static string nome;

        private static string login;

        private static DateTime aniversario;

        public static bool Logado
        {
            set
            {
                logado = value;
            }
            get
            {
                return logado;
            }
        }

        public static string Permissao
        {
            set
            {
                permissao = value;
            }
            get
            {
                return permissao;
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
            Logado = false;
            Permissao = null;
            Email = null;
            Nome = null;
            Login = null;
            aniversario = DateTime.Now;
        }
}
}
