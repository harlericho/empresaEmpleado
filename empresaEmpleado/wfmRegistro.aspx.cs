using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using LogicaNegocio;
namespace empresaEmpleado
{
    public partial class wfmRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //nuevo registro
        private void nuevvoRegistro()
        {
            txtNombres.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtRepass.Text = "";
            txtNombres.Focus();
        }

        //metodo encriptado
        private static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted =
            System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        //guardar registro

        private void guardarRegistro()
        {
            tbl_usuario _infoUsuario = new tbl_usuario();
            _infoUsuario.nombres_usuario = txtNombres.Text.ToUpper();
            _infoUsuario.dni_usuario = txtDni.Text;
            _infoUsuario.email_usuario = txtEmail.Text.ToLower();
            _infoUsuario.pass_usuario = Encriptar(txtRepass.Text);
            _infoUsuario.id_rol = 1;
            bool res = LogicaUsuario.guardarUsuarios(_infoUsuario);
            if (res)
            {
                Response.Write("<script>alert('Usuario nuevo guardado');</script>");
                nuevvoRegistro();
            }
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            tbl_usuario _infoUsuario1 = new tbl_usuario();
            tbl_usuario _infoUsuario2 = new tbl_usuario();
            if (txtPass.Text.Equals(txtRepass.Text))
            {
                _infoUsuario1 = LogicaUsuario.obtenerUsuariosDni(txtDni.Text);
                _infoUsuario2 = LogicaUsuario.obtenerUsuariosEmail(txtEmail.Text);
                if (_infoUsuario1 != null)
                {
                    Response.Write("<script>alert('Dni o CI ya existe, Revisar !!');</script>");
                    txtDni.Focus();
                }
                else if (_infoUsuario2 != null)
                {
                    Response.Write("<script>alert('Email ya existe, Revisar !!');</script>");
                    txtEmail.Focus();
                }
                else
                {
                    guardarRegistro();
                }
            }
            else
            {
                txtPass.Focus();
                Response.Write("<script>alert('Contraseñas no son iguales, Revisar !!');</script>");
                
            }
        }
    }
}