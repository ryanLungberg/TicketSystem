using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem
{
    public partial class FrmCreateCategory : Form
    {
        public FrmCreateCategory()
        {
            InitializeComponent();
        }

        private void FrmCreateCategory_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnSubmitCategory_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                Genre newGenre = new Genre();
                newGenre.GenreName = txtCategoryName.Text;

                if (!string.IsNullOrWhiteSpace(txtCategoryInfo.Text))
                {
                    newGenre.GenreInfo = txtCategoryInfo.Text;
                }

                db.Genres.Add(newGenre);
                int SubmitNewGenre = db.SaveChanges();
                if (SubmitNewGenre > 0) {

                    MessageBox.Show("Success: New Category Created");
                    ClearForm();

                }
                else
                {
                    MessageBox.Show("Error: Something Went Wrong. Category not uptated");
                }
            }
        }

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
        private void ClearForm()
        {
            txtCategoryInfo.Text = "";
            txtCategoryName.Text = "";
        }
    }
}
