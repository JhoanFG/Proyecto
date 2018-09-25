using System;

namespace Proyecto.Web.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if(!IsPostBack)
           // ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Buen Trabajo!', 'Se realizo con exito!', 'success') </script>");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese el email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese el Password,";


                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));


                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtEmail.Text,
                    stPassword = txtPassword.Text
                };

                Controllers.LoginController obLoginController = new Controllers.LoginController();
                bool blBandera = obLoginController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                    Response.Redirect("../Index/Index.aspx");

                else
                    throw new Exception("Usuario o password incorrecto");
            }

            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'Error') </script>");


            }


        }
    }
}