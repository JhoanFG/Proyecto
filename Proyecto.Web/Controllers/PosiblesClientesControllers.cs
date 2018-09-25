using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
namespace Proyecto.Web.Controllers
{
    public class PosiblesClientesControllers
    {
        public DataSet getConsultatPosiblesClientesController()

        {
            try
            {
                Logica.BL.clsPosiblesClientes obclsPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.getConsultarPosiblesClientes();
            }

            catch (Exception ex) { throw ex; }
        }


        public string setAdministrarPosiblesClientesController(Logica.Models.clsPosiblesClientes obclsPosiblesClientesModels, int inOpcion)

        {
            try
            {
                Logica.BL.clsPosiblesClientes obclsPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.setAdministrarPosiblesClientes(obclsPosiblesClientesModels, inOpcion);

            }

            catch(Exception ex) { throw ex; }
            }
    }
}

    


