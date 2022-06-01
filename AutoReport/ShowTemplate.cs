using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoReport
{
    public partial class ShowTemplate : Form
    {
        public ShowTemplate()
        {
            InitializeComponent();
            //string DBdir = Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetExecutingAssembly().EscapedCodeBase).LocalPath);

            //string PathTemplates = Path.Combine(DBdir, "Template"); ;
            DirectoryInfo dir = new DirectoryInfo(@"\НИР.Практика.Диплом\Практика\AutoReport\AutoReport\Template");
            
            FileInfo[] files = dir.GetFiles("*.docx"); 
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count == 1)
            {
                Sort sort = new Sort();
                sort.Show();
                Hide();

            }
                
            else
                MessageBox.Show("Ничего не выбрано!");
        }
    }

}
