using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
namespace Proyecto.Logica.BL
{
    public class clsConexion
    {


        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();


        }
    }
}
