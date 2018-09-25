<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src ="../../js/sweetalert.min.js" type="text/javascript"> </script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css"  />
    <div class="mx-auto mt-5">
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h1><b>Posibles Clientes</b></h1>
                  <asp:Label runat="server" ID="lblOpcion" Visible="false" ></asp:Label>

                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblIdentificacion" Text="Identificacion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control"></asp:TextBox>


                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblEmpresa" Text="Empresa"></asp:Label>
                    <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer Nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo Nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSegundoNombre" CssClas="form-control"></asp:TextBox>

                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer Apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo Apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblDireccion" Text="Direccion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblTelefono" Text="Telefono"></asp:Label>
                    <asp:TextBox runat="server" ID="txtTelefono" CssClas="form-control"></asp:TextBox>

                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">

                      <h3><b>Resultado</b></h3>

                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12" style="overflow:auto">
                    <asp:GridView runat="server"
                        ID="gvwDatos"
                        Width="100%"
                        AutoGenerateColumns="False"
                        EmptyDataText="No se Encontraron Registros"
                        OnRowCommand="gvwDatos_RowCommand">

                        <Columns>
                            <asp:TemplateField HeaderText="Indentificacion">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("clieIdentificacion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Empresa" DataField="clieEmpresa" />
                            <asp:BoundField HeaderText="Primer Nombre" DataField="cliePrimerNombre" />
                            <asp:BoundField HeaderText="Segundo Nombre" DataField="clieSegundoNombre" />
                            <asp:BoundField HeaderText="Primer Apellido" DataField="cliePrimerApellido" />
                            <asp:BoundField HeaderText="Segundo Apellido" DataField="clieSegundoApellido" />
                            <asp:BoundField HeaderText="Direccion" DataField="clieDireccion" />
                            <asp:BoundField HeaderText="Telefono" DataField="clieTelefono" />
                            <asp:BoundField HeaderText="Correo" DataField="clieCorreo" />

                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="ibEditar" imageURL="~/Resources/Images/Edit.gif"
                                        commandName="" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>




                             <asp:TemplateField HeaderText= "Eliminar">
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="ibEliminar" imageURL="~/Resources/Images/Remove.gif"
                                        commandName="Editar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>

                        </Columns>


                    </asp:GridView>

                </div>
            </div>
        </div>

    </div>
</asp:Content>
