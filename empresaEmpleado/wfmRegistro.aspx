<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmRegistro.aspx.cs" Inherits="empresaEmpleado.wfmRegistro" %>

<!DOCTYPE html>
<html>
<head>
    <link rel="icon" href="Iconos/icono.ico">
    <title>EMPRESA SURTEX S.A</title>
    <!-- Bootstrap -->
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen">
    <link href="bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" media="screen">
    <link href="assets/styles.css" rel="stylesheet" media="screen">
    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <script src="js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>
</head>
<body id="login">
    <div class="container">

        <form class="form-signin" runat="server">
            <h2 class="form-signin-heading">
                <img src="Iconos/users.ico" height="30" width="30" />
                Sistema Registro</h2>
            <asp:TextBox ID="txtNombres" class="input-block-level" runat="server" placeholder="Nombres" required autofocus></asp:TextBox>
            <asp:TextBox ID="txtDni" class="input-block-level" runat="server" placeholder="Dni o CI" required></asp:TextBox>
            <asp:TextBox ID="txtEmail" class="input-block-level" runat="server" placeholder="E-mail" required></asp:TextBox>
            <asp:TextBox ID="txtPass" class="input-block-level" runat="server" TextMode="Password" placeholder="Contraseña" required></asp:TextBox>
            <asp:TextBox ID="txtRepass" class="input-block-level" runat="server" TextMode="Password" placeholder="Repetir contraseña" required></asp:TextBox>
            <br />
            <asp:Button ID="btnRegistro" runat="server" Text="Registro" class="btn btn-large btn-info" OnClick="btnRegistro_Click" />
            <br />
            <br />
            <a href="wfmLogin.aspx" class="btn btn-primary btn-mini">Ir a login</a>
        </form>
        <center>
            <p class="mt-5 mb-3 text-muted">© 2020-2021</p>
        <div class="copyright">
            &copy; Copyright <strong><span>by:</span></strong>
            <a href="https://twitter.com/CarlChokSanc">CarlosChocaSanchez</a>
        </div>
        </center>
    </div>
    <!-- /container -->
    <script src="vendors/jquery-1.9.1.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
