using System;
using Examen_Repo.DAO;
using Examen_Repo.Entidades;
using System.Windows.Forms;
using Examen_Repo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Repo.Controladores
{
    public class Control_Login
    {
        Login vista;

        public Control_Login(Login view) 
        {
            vista = view;
            Vista.AceptarButton.Click += new EventHandler(ValidarUsuario);
        }
        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool Valido = false;
            UsuarioDAO userDao = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Nombre = Vista.NombretextBox.Text;
            user.Clave = (Vista.ContraseñaTextBox.Text);

            Valido = userDao.ValidarUsuario(user);

            if (Valido)
            {
                MessageBox.Show("Nombre Valido");

                Form1 f2 = new Form1();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Nombre incorrecto");
            }
        }

    }
}
