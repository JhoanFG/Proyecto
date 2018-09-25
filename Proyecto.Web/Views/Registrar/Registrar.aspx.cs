using System;

namespace Proyecto.Web.Views.Registrar
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if(!IsPostBack)
            // ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Buen Trabajo!', 'Se realizo con exito!', 'success') </script>");
        }

        protected void btnAceptar_Click2(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtPrimerNombre.Text)) stMensaje += "Ingrese el Nombre,";
                if (string.IsNullOrEmpty(txtSegundoNombre.Text)) stMensaje += "Ingrese el Apellido,";
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese el email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese el Password,";
                if (string.IsNullOrEmpty(txtConfPassword.Text)) stMensaje += "Confirme el Password,";
             
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));
            }

            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'Error') </script>");


            }


        }

        
        }
    }
