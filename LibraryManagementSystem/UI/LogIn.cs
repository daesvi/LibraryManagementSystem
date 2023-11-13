using LibraryManagementSystem.data;
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
                    // Password is correct, login successful
                    MessageBox.Show("Inicio de sesión exitoso.");
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
