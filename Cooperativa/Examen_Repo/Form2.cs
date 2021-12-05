using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Repo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();

            this.Hide();
            f3.ShowDialog();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
