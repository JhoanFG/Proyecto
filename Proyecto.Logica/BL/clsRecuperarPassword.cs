using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsRecuperarPassword
    {
        SqlConnection _SqlConnection = null;
        SqlCommand _sqlCommand = null;
        SqlDataAdapter _sqlDataAdapter = null;
        string stConexion = string.Empty;

        SqlParameter _SqlParameter = null;

        public clsRecuperarPassword()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();

        }


        public DataSet getConsultarPassword(Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _sqlCommand = new SqlCommand("spConsultarPassword", _SqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@Login", obclsUsuarios.stLogin));

                _sqlCommand.ExecuteNonQuery();

                _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }

            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
