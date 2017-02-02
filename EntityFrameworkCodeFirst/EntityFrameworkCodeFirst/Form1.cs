using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.name = txtName.Text;
            stu.DateOfBirth = dtpDateOfBirth.Value;

            StudentDBHelper.AddStudent(stu);
        }
    }
}
