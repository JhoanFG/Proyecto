using System;

using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{
   public class clsUsuarios
    {

        SqlConnection _SqlConnection = null;
        SqlCommand _sqlCommand = null;
        SqlDataAdapter _sqlDataAdapter = null;
        string stConexion = string.Empty;


        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();


        }

        public bool getValidarUsuario(Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _sqlCommand = new SqlCommand("spConsultarUsuario", _SqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@Login", obclsUsuarios.stLogin));
                _sqlCommand.Parameters.Add(new SqlParameter("@Password", obclsUsuarios.stPassword));


                _sqlCommand.ExecuteNonQuery();

                _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _sqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;
            }

            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    
    }
}
