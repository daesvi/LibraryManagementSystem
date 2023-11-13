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
    public partial class LibrarianForm : MaterialForm
    {
        public LibrarianForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,
                Primary.Grey500, Accent.Indigo700,
                TextShade.WHITE
            );

            titleBox.Hint = "Título del libro";
            authorBox.Hint = "Autor del libro";
            yearBox.Hint = "Año de publicación";
            idBookBox.Hint = "ID del libro a prestar";
            idUserBox.Hint = "ID de la persona a la que se presta";
            idBox.Hint = "ID del libro a modificar";
            titleBookBox.Hint = "Nombre del libro corregido";
            copiesBookBox.Hint = "Nuevo número de copias";
            authorBookBox.Hint = "Nombre del autor corregido";
            titleSearchBox.Hint = "Buscar por titulo";
            authorSearchBox.Hint = "Buscar por autor";
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
        }

        private void registerLoanBtn_Click(object sender, EventArgs e)
        {

        }

        private void registerBookBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchTitleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
