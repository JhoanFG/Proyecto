using System;

using System.Data;

namespace Proyecto.Web.Controllers
{
    public class TareasController
    {
        public DataSet getConsultatTareasController()

        {
            try
            {
                Logica.BL.clsEstadoTareas obclsclsEstadoTareas = new Logica.BL.clsEstadoTareas();
                return obclsclsEstadoTareas.getConsultarEstadoTarea();   
            }

            catch (Exception ex) { throw ex; }
        }


        public DataSet getConsultatPrioridadController()

        {
            try
            {
                Logica.BL.clsPrioridad obclsclsPrioridad = new Logica.BL.clsPrioridad();
                return obclsclsPrioridad.getConsultarPrioridad();
            }

            catch (Exception ex) { throw ex; }
        }

    }
}