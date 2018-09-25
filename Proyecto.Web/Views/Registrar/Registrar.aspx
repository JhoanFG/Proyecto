<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Proyecto.Web.Views.Registrar.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Registrar</title>

    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet"/>
    <!-- Bootstrap core JavaScript-->
    <script// src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</head>
<body class="bg-dark">

    <div class="container">
        <div class="card card-register mx-auto mt-5">
            <div class="card-header">Registrar nueva cuenta</div>
            <div class="card-body">
                 <form id="form1" runat="server">
                    <div class="form-group">                     
                               
                                    <asp:Label ID="lblPrimerNombre" runat="server" Text="Primer Nombre"></asp:Label>
                                    <asp:TextBox ID="txtPrimerNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                    
                    <div class="form-group">
                             
                                    <asp:Label ID="lblSegundoNombre" runat="server" Text="SegundoNombre"></asp:Label>
                                    <asp:TextBox ID="txtSegundoNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                          
                    <div class="form-group">
                     
                            <asp:Label ID="lblEmail" runat="server" Text="Ingrese Email"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                 
                    <div class="form-group">
             
                                    <asp:Label ID="lblPassword" runat="server" Text="Ingrese Password"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                      <div class="form-group">
                               
                                    <asp:Label ID="lblConfPassword" runat="server" Text="Confirmar Password"></asp:Label>
                                    <asp:TextBox ID="txtConfPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                          
              <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary btn-block" Text="Aceptar" OnClick="btnAceptar_Click2"/>
                    
            
                      </form>
        
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Login/Login.aspx">Pagina de login</a>
                    <a class="d-block small" href="#">Oldivaste la contraseña?</a>
                </div>
            </div>
        </div>
        </div>
</body>
</html>
