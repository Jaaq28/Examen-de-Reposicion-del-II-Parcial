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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarBbutton_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();

            this.Hide();
            f3.ShowDialog();
        }

        private void MovimientoButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            this.Hide();
            f3.ShowDialog();
        }
    }
}
