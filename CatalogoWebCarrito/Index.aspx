<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CatalogoWebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <nav class="navbar navbar-dark bg-dark">
        <div class="container">
            <div class="row">
                <div class="col">
                    <p></p>
                    <asp:Label ID="lblCantidad" CssClass="alert alert-dark" runat="server" Text=""></asp:Label>
                    <p></p>
                </div>
            </div>
        </div>
    </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <p>&nbsp;</p>

        <div class="card-columns" style="margin-left: 15px; margin-right: 15px">
            <%foreach (var articulo in lista)
                {%>
            <div class="card" style="width: 18rem;">
                <img src="<% = articulo.URL_Imagen%>" class="card-img-top" style="height:200px;width:200px;" alt="<% = articulo.Nombre%>">
                <div class="card-body">
                    <h5 class="card-title"><% = articulo.Nombre%></h5>
                    <p class="card-text"><% = articulo.Descripcion%></p>
                    <p class="card-text">Precio: $<% = articulo.Precio.ToString()%></p>
                    <a href="#" class="btn btn-primary">Agregar a carrito</a>
                </div>
            </div>
            <%}%>
        </div>
        <div class="row justify-content-center">
            <asp:Button ID="Boton1" runat="server" Text="No apriete este botón" OnClick="Boton1_Click" />
        </div>
        <div class="row justify-content-center">
            <asp:Label ID="lblPrueba" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
