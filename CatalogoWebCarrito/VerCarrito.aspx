<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="CatalogoWebCarrito.VerCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" style="border-left:none;border-right:none;border-bottom:dashed;border-top:dashed;border-width:1px;border-color:white;">
        <a class="btn btn-outline-light" style="margin-right:15px;" href="Index.aspx"><strong>Ver catálogo</strong></a>
        <img src="https://image.flaticon.com/icons/svg/777/777205.svg" style="max-width: 25px; max-height: 25px;margin-right:10px;"/>
        <a class="navbar-brand"><%= ContarCarrito()%> elementos &nbsp;| &nbsp;$<%= SubtotalCarrito()%></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <a class="btn btn-success" href="VerCarrito.aspx?comprar=todo" style="margin-left:5px;">Comprar todo</a>
        <a class="btn btn-danger" href="VerCarrito.aspx?eliminar=todo" style="margin-left:5px;">Borrar todo</a>
    </nav>
    <div class="container" style="padding: 10px;">
        <div class="container">
            <div class="row justify-content-center" style="width: auto; height: auto;">
                <h3 style="color:white;">Mi carrito:</h3>
            </div>
        </div>
        <div class="jumbotron">
            <h4 style="text-align:center;"><%=MensajeCarritoVacio()%></h4>
            <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
                <asp:Repeater runat="server" ID="listaCarrito">
                    <ItemTemplate>
                        <div class="card">
                            <img src="<%#Eval("Articulo.URL_Imagen") %>" class="card-img-top" style="display: block; height: 200px; width: 200px; margin-left: auto; margin-right: auto;" alt="<%#Eval("articulo.Nombre")%>">
                            <div class="card-body">
                                <h5 class="card-title" style="text-align: center;"><%#Eval("Articulo.Nombre")%></h5>
                                <p class="card-text" style="text-align: center;"><%#Eval("Articulo.Descripcion")%></p>
                                <p class="card-text" style="text-align: center;font-size:large;"><%#Eval("Cantidad")%> x $<%#Convert.ToDouble(Eval("articulo.Precio"))%></p>
                                <p class="card-text" style="text-align: center;font-size:large;">Total: <strong>$<%#Convert.ToDouble(Eval("Articulo.Precio"))*Convert.ToInt32(Eval("Cantidad"))%></strong></p>
                                <div class="container" style="text-align: center; padding: 5px;">
                                    <div class="row" style="display: inline-block">
                                        <a href="VerCarrito.aspx?comprar=<%#Eval("ID_elemento")%>" class="btn btn-success">Comprar</a>
                                        <a href="VerCarrito.aspx?eliminar=<%#Eval("ID_elemento")%>" class="btn btn-danger">Eliminar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
