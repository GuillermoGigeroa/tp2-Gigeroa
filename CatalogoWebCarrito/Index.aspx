<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CatalogoWebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="navbar navbar-dark bg-dark">
        <div class="container">
            <div class="row">
                <div class="col" style="padding: 10px;">
                    <a href="VerCarrito.aspx" class="alert alert-success" style="text-align: center;">Mi carrito [<%= ContarCarrito()%>] - Subtotal $<%= SubtotalCarrito()%></a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding: 10px;">
        <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>
                    <div class="card" style="border: solid; border-color: antiquewhite; border-width: 1px;">
                        <img src="<%#Eval("URL_Imagen") %>" class="card-img-top" style="display: block; height: 200px; width: 200px; margin-left: auto; margin-right: auto;" alt="<%#Eval("Nombre")%>">
                        <div class="card-body">
                            <h5 class="card-title" style="text-align: center"><%#Eval("Nombre")%></h5>
                            <p class="card-text" style="text-align: center"><%#Eval("Descripcion")%></p>
                            <p class="card-text" style="text-align: center">$<%#Convert.ToDouble(Eval("Precio"))%></p>
                        </div>
                        <div class="container" style="text-align: center; padding: 5px;">
                            <div class="row" style="display: inline-block">
                                <div class="btn-group">
                                    <button type="button" class="btn btn-success dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        Agregar al carrito
                                    </button>
                                    <div class="dropdown-menu">
                                        <%for (int cant = 1; cant <= 10; cant += 1)
                                          {%>
                                            <a class="dropdown-item" href="Index.aspx?idArt=<%#Eval("ID_Articulo")%>&cant=<%=cant%>">Agregar <%=cant%> - <%#Eval("Nombre")%></a>
                                        <%}%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>
