using System;

namespace Proyecto.Web.Resources.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string[] stEmail = null;

                if (Session["SessionEmail"] != null)
                {
                    stEmail = Session["SessionEmail"].ToString().Split('@');
                    lblUsuario.Text = stEmail[0];
                }
                else

                    Response.Redirect("../../Views/Login/Login.aspx");
                    
            }
        }

       
        

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
        }
    }
}