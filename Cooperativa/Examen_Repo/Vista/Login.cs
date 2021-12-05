using System;
using Examen_Repo.Controladores;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Control_Login controlador = new Control_Login(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
