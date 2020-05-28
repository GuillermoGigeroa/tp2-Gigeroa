<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CatalogoWebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" style="border-left:none;border-right:none;border-bottom:dashed;border-top:dashed;border-width:1px;border-color:white;">
        <a class="navbar-brand" href="VerCarrito.aspx">Ver mi carrito</a>
        <a class="navbar-brand">| &nbsp;<%= ContarCarrito()%> elementos &nbsp;| &nbsp;$<%= SubtotalCarrito()%> &nbsp;|</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item dropdown active">
                    <a class="nav-link dropdown-toggle" href="#" id="listaMarcas" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Marcas </a>
                    <div class="dropdown-menu" aria-labelledby="listaMarcas">
                        <%foreach (var marca in listaMarcas)
                          {%>
                           <a class="dropdown-item" href="Index.aspx?filtroMarca=<%= marca.ID_Marca%>"><%= marca.Nombre%></a>
                        <%}%>
                    </div>
                </li>
                <li class="nav-item dropdown active">
                    <a class="nav-link dropdown-toggle" href="#" id="listaCategorias" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Categorías </a>
                    <div class="dropdown-menu" aria-labelledby="listaCategorias">
                        <%foreach (var categoria in listaCategorias)
                          {%>
                           <a class="dropdown-item" href="Index.aspx?filtroCategoria=<%= categoria.ID_Categoria%>"><%= categoria.Nombre%></a>
                        <%}%>
                    </div>
                </li>
            </ul>
            <form class="form-inline my-2 my-lg-0">
                <input class="form-control mr-sm-2" id="busqueda" type="search" placeholder="Buscar artículo" aria-label="Buscar artículo">
                <a href="Index.aspx?buscar=loquebusco" class="btn btn-outline-success my-2 my-sm-0" type="submit">Buscar</a>
                <%--<button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>--%>
            </form>
        </div>
    </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding: 10px;">
        <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>
                    <div class="card" style="border: solid; border-color: antiquewhite; border-width: 1px;">
                        <img src="<%#Eval("URL_Imagen")%>" class="card-img-top" style="display: block; height: 200px; width: 200px; margin-left: auto; margin-right: auto;" alt="<%#Eval("Nombre")%>">
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
