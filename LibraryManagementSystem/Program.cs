using LibraryManagementSystem.data;
using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.repository;
using LibraryManagementSystem.services;
using LibraryManagementSystem.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
           LibraryContext libraryContext = new LibraryContext();
           IUserRepository userRepository = new UserRepository(libraryContext);
           IUserService userService = new UserService(userRepository);
           Application.Run(new LogIn(userService)); */

            //Application.Run(new LibrarianForm());
            Application.Run(new UserForm());
        }
    }
}
