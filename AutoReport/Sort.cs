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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowTemplate showTemplate = new ShowTemplate();
            showTemplate.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
