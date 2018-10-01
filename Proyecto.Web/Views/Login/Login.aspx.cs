using System;
using System.Web;

namespace Proyecto.Web.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                if (Request.Cookies["cookieEmail"] != null)
                    txtEmail.Text = Request.Cookies["cookieEmail"].Value.ToString();
            }
         
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
                {

                    Session["SessionEmail"] = txtEmail.Text; 

                    if (chkRecordar.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
                        cookie.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Add(cookie);

                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);

                    }



                    Response.Redirect("../Index/Index.aspx?stEmail=" + txtEmail.Text);
                }

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