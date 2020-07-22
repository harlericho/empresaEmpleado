using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace LogicaNegocio
{
    public class LogicaUsuario
    {
        private static DCEmpresaDataContext dc { get; set; }


        //listado usuario
        private static List<tbl_usuario> obtenerUsuarios()
        {
            try
            {
                dc = new DCEmpresaDataContext();
                var usuarios = dc.tbl_usuarios.Where(data => data.estado_usuario == 'A');
                return usuarios.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR: " + ex.Message);
            }
        }

        //validacion por login
        public static tbl_usuario obtenerUsuariosLogin(string user, string pass)
        {
            try
            {
                dc = new DCEmpresaDataContext();
                var usuarios = dc.tbl_usuarios.FirstOrDefault(data => data.estado_usuario == 'A'
                && data.email_usuario.Equals(user) && data.pass_usuario.Equals(pass));
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERROR" + ex.Message);
            }
        }


        //validacion dni usuarios
        public static tbl_usuario obtenerUsuariosDni(string datoDni)
        {
            try
            {
                dc = new DCEmpresaDataContext();
                var usuarios = dc.tbl_usuarios.FirstOrDefault(data => data.estado_usuario == 'A'
                && data.dni_usuario.Equals(datoDni));
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //validacion email usuarios
        public static tbl_usuario obtenerUsuariosEmail(string datoEmail)
        {
            try
            {
                dc = new DCEmpresaDataContext();
                var usuarios = dc.tbl_usuarios.FirstOrDefault(data => data.estado_usuario == 'A'
                && data.email_usuario.Equals(datoEmail));
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERROR" + ex.Message);
            }
        }


        //guardar usuarios
        public static bool guardarUsuarios(tbl_usuario _infoUsuario)
        {
            try
            {
                dc = new DCEmpresaDataContext();
                bool res = false;
                _infoUsuario.estado_usuario = 'A';
                _infoUsuario.fecha_usuario = DateTime.Now;
                dc.tbl_usuarios.InsertOnSubmit(_infoUsuario);
                dc.SubmitChanges();
                res = true;
                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }

        //eliminar usuarios
        public static bool eliminarUsuarios(tbl_usuario _infoUsuario)
        {
            try
            {
                bool res = false;
                _infoUsuario.estado_usuario = 'I';
                dc.SubmitChanges();
                res = true;
                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("ERROR" + ex.Message);
            }
        }
    }
}
