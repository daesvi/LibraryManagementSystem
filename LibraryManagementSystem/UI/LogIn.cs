using LibraryManagementSystem.data;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.services;
using LibraryManagementSystem.ui;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LogIn : MaterialForm
    {
        private readonly IUserService userService;
        public LogIn(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,
                Primary.Grey500, Accent.Indigo700,
                TextShade.WHITE
            );

            idBox.Hint = "Número de identificación";
            passwordBox.Hint = "Contraseña";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            this.Show();
        }

        private void eye2Picture_Click(object sender, EventArgs e)
        {
            if (passwordBox.Password)
            {
                passwordBox.Hide();
                passwordBox.Password = false;
                eye2Picture.Image = Properties.Resources.cerrado;
                passwordBox.Show();
            }
            else
            {
                passwordBox.Hide();
                passwordBox.Password = true;
                eye2Picture.Image = Properties.Resources.vista;
                passwordBox.Show();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            // Open the registration form
            SignUp signUpForm = new SignUp(userService);
            signUpForm.ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long userId = long.Parse(idBox.Text);
                string password = passwordBox.Text;

                // Check if the username and password are valid
                bool isValidLogin = userService.login(userId, password);

                if (isValidLogin)
                {
                    // Password is correct, get the user
                    User loggedInUser = userService.GetById(userId);
                    // Check the "tipo" field and open the corresponding form
                    if (loggedInUser != null)
                    {
                        if (loggedInUser.Tipo == 1)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            // Open the form UserForm
                            /*
                            UserForm userForm = new UserForm();
                            userForm.ShowDialog();*/
                        }
                        else if (loggedInUser.Tipo == 2)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            // Open the form LibrarianForm
                            /*
                            LibrarianForm librarianForm = new LibrarianForm();
                            librarianForm.ShowDialog();*/
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, verifica tus credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID de usuario no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
