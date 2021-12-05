using System;
using Examen_Repo.Controladores;
using Examen_Repo.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Examen_Repo;
using System.Threading.Tasks;

namespace Examen_Repo.DAO
{
    public class Usuario_Control
    {
        UsuariosView vista;
        string operacion = string.Empty;
        UsuarioDAO userDAO = new UsuarioDAO();
        Usuario user = new Usuario();

        public UsuarioController(UsuariosView view)
        {
            vista = view;


            vista.Load += new EventHandler(Load);

        }
        private void Nuevo(object serder, EventArgs e)
        {

        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {

            vista.dtg.DataSource = userDAO.getusuarios();


        }

    }
}
