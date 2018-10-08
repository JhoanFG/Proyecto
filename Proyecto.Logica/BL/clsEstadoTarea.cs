using System;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsEstadoTareas
    {
        SqlConnection _SqlConnection = null;
        SqlCommand _sqlCommand = null;
        SqlDataAdapter _sqlDataAdapter = null;
        string stConexion = string.Empty;

        SqlParameter _SqlParameter = null;

        public clsEstadoTareas()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();

        }


        public DataSet getConsultarEstadoTarea()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _sqlCommand = new SqlCommand("spConsultarEstadosTareas", _SqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

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
