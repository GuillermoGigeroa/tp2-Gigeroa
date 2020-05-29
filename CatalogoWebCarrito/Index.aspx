<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CatalogoWebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" style="border-left: none; border-right: none; border-bottom: dashed; border-top: dashed; border-width: 1px; border-color: white;">
        <a class="btn btn-outline-light" style="margin-right: 15px;" href="Index.aspx"><strong>Inicio</strong></a>
        <a class="btn btn-outline-light" style="margin-right: 15px;" href="VerCarrito.aspx"><strong>Ver mi carrito</strong></a>
        <img src="https://image.flaticon.com/icons/svg/777/777205.svg" style="max-width: 25px; max-height: 25px; margin-right: 10px;" />
        <a class="navbar-brand"><%= ContarCarrito()%> elementos &nbsp;| &nbsp;$<%= SubtotalCarrito()%></a>
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
            <div class="form-inline my-2 my-lg-0">
                <button type="button" class="btn btn-light" style="margin-right: 10px;" data-toggle="modal" data-target="#exampleModal">
                    <img src="https://media3.giphy.com/media/26n7b7PjSOZJwVCmY/giphy.gif?cid=ecf05e47ba5abdfb329af3570845ef6ca6989a084b1f05ec&rid=giphy.gif" style="max-width: 25px; max-height: 25px;" alt="GigeroaBlack" />
                </button>
                <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLabel">Sistema de carrito web</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="container align-content-center">
                                    <div class="row">
                                        <p style="text-align: center;">Gracias por utilizar mi primer sistema de carrito web.</p>
                                    </div>
                                    <div class="row">
                                        <div class="col" style="width: auto; height: auto;">
                                            <img src="https://media3.giphy.com/media/lOgu1OnjYF2GHBfRU4/giphy.gif?cid=ecf05e47c78a3a1f8ee5d58ed993da31015f474fb806b8dd&rid=giphy.gif" style="max-width: 200px; max-height: 200px;" />
                                        </div>
                                        <div class="col" style="width: auto; height: auto; margin-left: 40px;">
                                            <img src="https://guillermogigeroa.github.io/portfolio-personal/images/miFoto.jpg" style="width: 150px; border-radius: 200px 200px 200px 200px; -moz-border-radius: 200px 200px 200px 200px; -webkit-border-radius: 200px 200px 200px 200px;" />
                                            <p style="height: 1px;"></p>
                                            <a class="btn btn-dark" style="vertical-align: central; margin-left: 20px;" href="https://guillermogigeroa.github.io/portfolio-personal/" target="_blank">¿Quién soy?</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                            </div>
                        </div>
                    </div>
                </div>
                <asp:TextBox CssClass="form-control mr-sm-2" ID="txtBuscar" runat="server"></asp:TextBox>
                <asp:Button CssClass="btn btn-outline-light my-2 my-sm-0" Font-Bold="true" ID="btnBuscar" runat="server" Text="Buscar" OnClick=" btnBuscar_Click" />
            </div>
        </div>
    </nav>
    <div class="container" style="padding: 10px;">
        <p style="color: white;"><strong><%=MensajeBusqueda()%></strong></p>
        <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>
                    <div class="card" style="border: solid; border-color: antiquewhite; border-width: 1px;">
                        <img src="<%#Eval("URL_Imagen")%>" class="card-img-top" style="display: block; height: 200px; width: 200px; margin-left: auto; margin-right: auto;" alt="<%#Eval("Nombre")%>">
                        <div class="card-body">
                            <p class="card-text" style="text-align: center; font-size: x-large; color: red;"><strong>$<%#Convert.ToDouble(Eval("Precio"))%></strong></p>
                            <p class="card-text" style="text-align: center; font-size: large; color: grey;">
                                <s>$<%#Convert.ToInt32(Eval("Precio"))*OfertaDudosa()%></s>
                                <span style="color: forestgreen">
                                    <strong><%= Convert.ToInt32((OfertaDudosa()-1)*100)%>% OFF</strong>
                                </span>
                            </p>
                            <h5 class="card-title" style="text-align: center;"><%#Eval("Nombre")%></h5>
                            <p class="card-text" style="text-align: center;"><%#Eval("Descripcion")%></p>
                        </div>
                        <div class="container" style="text-align: center; padding-bottom: 15px;">
                            <div class="row" style="display: inline-block">
                                <div class="btn-group">
                                    <button type="button" class="btn btn-dark dropdown-toggle" style="padding-bottom: 9px;" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
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
    <footer>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark" style="height: 15px;">
        </nav>
    </footer>
</asp:Content>
