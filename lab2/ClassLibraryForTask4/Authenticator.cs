using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask3_4
{
    public sealed class Authenticator
    {
        private static volatile Authenticator instance;
        private static object syncRoot = new Object();

        private Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Authenticator();
                    }
                }
                return instance;
            }
        }

        public void Authenticate(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (username == "admin" && password == "admin123")
                {
                    Console.WriteLine("Аутентифікація успішна.");
                }
                else
                {
                    Console.WriteLine("Аутентифікація не вдалася: Невірний логін або пароль.");
                }
            }
            else
            {
                Console.WriteLine("Аутентифікація не вдалася: Логін або пароль не вказані.");
            }
        }
    }
}
