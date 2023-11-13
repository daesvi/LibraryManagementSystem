using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.ui
{
    public partial class UserForm : MaterialForm
    {
        public UserForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,
                Primary.Grey500, Accent.Indigo700,
                TextShade.WHITE
            );

            titleSearchBox.Hint = "Buscar por titulo";
            authorSearchBox.Hint = "Buscar por autor";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void registerLoanBtn_Click(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
