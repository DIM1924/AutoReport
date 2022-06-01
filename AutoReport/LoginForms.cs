using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoReport
{
    public partial class AutoReport : Form
    {
        public AutoReport()
        {
            InitializeComponent();

        }

        private void ClouseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisibleClickDown(object sender, MouseEventArgs e)
        {
            this.Password.UseSystemPasswordChar = false;

        }

        private void VisibleClickUp(object sender, MouseEventArgs e)
        {
            this.Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Login.Text == "a"&& Password.Text=="a")
            {
                ShowTemplate showTemplate = new ShowTemplate();
                showTemplate.Show();
                Hide();

            }
            else if (Login.Text == "admin" && Password.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                Hide();
            }
        }
    }
}
