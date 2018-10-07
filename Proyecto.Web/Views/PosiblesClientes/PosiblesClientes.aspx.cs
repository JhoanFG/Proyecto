using System;

using System.Data;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page

    {
     
        void getPosiblesClientes()
        {
            try
            {
                Controllers.PosiblesClientesControllers obPosiblesClientesCotroller = new Controllers.PosiblesClientesControllers();
                DataSet dsConsulta = obPosiblesClientesCotroller.getConsultatPosiblesClientesController();


                if (dsConsulta.Tables[0].Rows.Count > 0)


                    gvwDatos.DataSource = dsConsulta;

                else

                    gvwDatos.DataSource = null;


                gvwDatos.DataBind();
            }
            catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'Error') </script>"); }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["SessionEmail"] == null)
                 Response.Redirect("../Login/Login.aspx");

                getPosiblesClientes();
            }           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtIdentificacion.Text)) stMensaje += "Ingrese Identificacion,";
              
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                Logica.Models.clsPosiblesClientes obclsPosiblesClientes = new Logica.Models.clsPosiblesClientes
                {
                    lnIdentificacion = Convert.ToInt64(txtIdentificacion.Text),
                    stEmpresa = txtEmpresa.Text,
                    stPrimerNombre = txtPrimerNombre.Text,
                    stSegundoNombre = txtSegundoNombre.Text,
                    stPrimerApellido = txtPrimerApellido.Text,
                    stSegundoApellido = txtSegundoApellido.Text,
                    stDireccion = txtDireccion.Text,
                    stTelefono = txtTelefono.Text,
                    stCorreo = txtCorreo.Text

                };

                Controllers.PosiblesClientesControllers obposiblesClientesControllers = new Controllers.PosiblesClientesControllers();

                if (string.IsNullOrEmpty(lblOpcion.Text)) lblOpcion.Text = "1";
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obposiblesClientesControllers.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(lblOpcion.Text)) + "!', 'Success') </script>");
               
                lblOpcion.Text = txtIdentificacion.Text = txtEmpresa.Text = txtPrimerNombre.Text = txtSegundoNombre.Text = txtPrimerApellido.Text = txtSegundoApellido.Text = txtDireccion.Text = txtTelefono.Text = txtCorreo.Text = string.Empty;

                getPosiblesClientes();

            }
            catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'Error') </script>");
            }
        }

        protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {

                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Editar"))
                {
                    lblOpcion.Text = "2";
                    txtIdentificacion.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text;
                    txtEmpresa.Text = gvwDatos.Rows[inIndice].Cells[1].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtPrimerNombre.Text = gvwDatos.Rows[inIndice].Cells[2].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtSegundoNombre.Text = gvwDatos.Rows[inIndice].Cells[3].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtPrimerApellido.Text = gvwDatos.Rows[inIndice].Cells[4].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[4].Text;
                    txtSegundoApellido.Text = gvwDatos.Rows[inIndice].Cells[5].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[5].Text;
                    txtDireccion.Text = gvwDatos.Rows[inIndice].Cells[6].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[6].Text;
                    txtTelefono.Text = gvwDatos.Rows[inIndice].Cells[7].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[7].Text;
                    txtCorreo.Text = gvwDatos.Rows[inIndice].Cells[8].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[8].Text;

                }

                else if(e.CommandName.Equals("Eliminar"))

                {
                    lblOpcion.Text = "3";

                    Logica.Models.clsPosiblesClientes obclsPosiblesClientes = new Logica.Models.clsPosiblesClientes
                    {
                        lnIdentificacion = Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text),
                        stEmpresa = string.Empty,
                        stPrimerNombre = string.Empty,
                        stSegundoNombre = string.Empty,
                        stPrimerApellido = string.Empty,
                        stSegundoApellido = string.Empty,
                        stDireccion = string.Empty,
                        stTelefono = string.Empty,
                        stCorreo = string.Empty

                    };

                    Controllers.PosiblesClientesControllers obposiblesClientesControllers = new Controllers.PosiblesClientesControllers();

                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obposiblesClientesControllers.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(lblOpcion.Text)) + "!', 'Success') </script>");
                   
                    lblOpcion.Text = string.Empty;

                    getPosiblesClientes();

                }
            }
            catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'Error') </script>");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblOpcion.Text = txtIdentificacion.Text = txtEmpresa.Text = txtPrimerNombre.Text = txtSegundoNombre.Text = txtPrimerApellido.Text = txtSegundoApellido.Text = txtDireccion.Text = txtTelefono.Text = txtCorreo.Text = string.Empty;

        }
    }
    }

