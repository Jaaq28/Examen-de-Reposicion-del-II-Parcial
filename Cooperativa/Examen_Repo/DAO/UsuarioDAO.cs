using System;
using System.Data.SqlClient;
using Examen_Repo.Entidades;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Repo.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT 1 FROM Loginn WHERE NOMBRE = @NOMBRE AND CONTRASEÑA =@Contraseña;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Usuario", SqlDbType.NVarChar, 100).Value = user.Nombre;
                comando.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50).Value = user.Clave;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

            }
            return valido;
        }
        public DataTable getusuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM USUARIO ");
                comando.Connection = MiConexion;

                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();



            }
            catch (Exception)
            {

            }
            return dt;

        }
    }
}
