using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;


namespace TicketSystem
{
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
        {
            InitializeComponent();
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            ReloadCategories();
        }

        //Loads the currently available categories into the combo-box at the top of the page.
        private void ReloadCategories()
        {
            cboxCategory.Items.Clear();
            foreach (Genre g in GetGenres())
            {
                cboxCategory.Items.Add(g.GenreName);
            }
        }

        //Retrieves the list of Genres from the database to be used later.
        private List<Genre> GetGenres()
        {
            using (TicketSystemDBEntities db = new TicketSystemDBEntities())
            {
                return db.Genres.ToList();
            }
        }

        //Makes sure data is entered into the boxes.
        private bool isValidData()
        {
            if (!string.IsNullOrWhiteSpace(txtCategoryInfo.Text) || !string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Missing Data please check entries.");
                return false;
            }
        }

        //Clears the textboxes on the form.
        private void ClearForm()
        {
            txtCategoryInfo.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                int indexToBeChanged = cboxCategory.SelectedIndex;
                Genre currentGenre = db.Genres.Find(indexToBeChanged);

                currentGenre.GenreName = txtCategoryName.Text;

                if (!string.IsNullOrWhiteSpace(txtCategoryInfo.Text))
                {
                    currentGenre.GenreInfo = txtCategoryInfo.Text;
                }

                //This line must be included to let Entity Framework know that the item has been changed in the database.
                db.Entry(currentGenre).State = System.Data.Entity.EntityState.Modified;

                //Did not know that SaveChanges returns an int, interesting application of that here
                db.SaveChanges();

                ClearForm();
                ReloadCategories();
            }
        }
    }
}
