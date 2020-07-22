<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmLogin.aspx.cs" Inherits="empresaEmpleado.wfmLogin" %>

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
                <img src="Iconos/login.ico" height="30" width="30" />
                Sistema Login</h2>
            <asp:TextBox ID="txtEmail" class="input-block-level" runat="server" placeholder="E-mail" required autofocus></asp:TextBox>
            <asp:TextBox ID="txtPass" class="input-block-level" runat="server" TextMode="Password" placeholder="Contraseña" required></asp:TextBox>
            <br />
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" class="btn btn-large btn-primary" />
            <br />
            <br />
            <a href="wfmRegistro.aspx" class="btn btn-info btn-mini">Ir a registro</a>
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
