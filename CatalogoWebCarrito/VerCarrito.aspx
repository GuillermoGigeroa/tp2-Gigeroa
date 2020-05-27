<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="CatalogoWebCarrito.VerCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <nav class="navbar navbar-dark bg-dark">
        <div class="container">
            <div class="row justify-content-between" style="padding: 10px">
                <p class="alert alert-info">Elementos en carrito: <%= ContarCarrito()%></p>
                <a href="Index.aspx" class="alert alert-success">Volver a catálogo</a>
            </div>
        </div>
    </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
            <div class="container">
                <div class="row justify-content-center">
                    <h2>Lista de objetos en carrito:</h2>
                </div>
            </div>
            <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
                <asp:Repeater runat="server" ID="listaCarrito">
                    <ItemTemplate>
                        <div class="card">
                            <img src="<%#Eval("articulo.URL_Imagen") %>" class="card-img-top" style="display: block; height: 200px; width: 200px; margin-left: auto; margin-right: auto;" alt="<%#Eval("articulo.Nombre")%>">
                            <div class="card-body">
                                <h5 class="card-title" style="text-align: center"><%#Eval("articulo.Nombre")%></h5>
                                <p class="card-text" style="text-align: center"><%#Eval("articulo.Descripcion")%></p>
                                <p class="card-text" style="text-align: center">$<%#Convert.ToDouble(Eval("articulo.Precio"))%></p>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
