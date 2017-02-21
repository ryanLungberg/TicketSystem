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
    public partial class FrmCreatePerformer : Form
    {
        public FrmCreatePerformer()
        {
            InitializeComponent();
        }

        private void FrmCreatePerformer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Once button is selected, check to see if valid data then adds new performer to database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmitPerformer_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Performer newPerformer = new Performer();
                newPerformer.PerformerName = txtPerformerName.Text;
                newPerformer.PerformerURL = txtPerformerUrl.Text;

                if (!String.IsNullOrWhiteSpace(txtPerformerInfo.Text))
                {
                    newPerformer.PerformerInfo = txtPerformerInfo.Text;
                }

                TicketSystemDBEntities db = new TicketSystemDBEntities();

                db.Performers.Add(newPerformer);

                int addPerformerToDatabase = db.SaveChanges();

                if (addPerformerToDatabase  > 0)
                {
                    MessageBox.Show("Success: Performer added");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error: Something Went wrong. Performer NOT added");
                }
            }
        }

        /// <summary>
        /// Check to see if all necesary fields of form are valid to create a new performer.
        /// </summary>
        /// <returns>return true if data is valid false if not or empty</returns>
        private bool IsValidData()
        {
            if (!String.IsNullOrWhiteSpace(txtPerformerName.Text) && !String.IsNullOrWhiteSpace(txtPerformerUrl.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //function clears all text boxes on Create Performer Form.
        private void ClearForm()
        {
            txtPerformerName.Text = "";
            txtPerformerUrl.Text = "";
            txtPerformerInfo.Text = "";
        }

    }
}
