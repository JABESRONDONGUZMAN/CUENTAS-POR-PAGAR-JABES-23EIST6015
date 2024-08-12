using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR_JABES_23EIST6015
{

    public static class PROVEEDORES_OPERACIONES
    {
        public static PROVEEDORESJABES23EIST6015 CARGAR(string codigo)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                var INFO = (from P in BD.PROVEEDORESJABES23EIST6015
                            where P.CODIGO == codigo
                            select P).SingleOrDefault();

                if (INFO != null)
                {
                    return new PROVEEDORESJABES23EIST6015
                    {
                        CODIGO = INFO.CODIGO,
                        NOMBRES = INFO.NOMBRES,
                        APELLIDOS = INFO.APELLIDOS,
                        DIRECCION = INFO.DIRECCION,
                        CIUDAD = INFO.CIUDAD,
                        TELEFONO = INFO.TELEFONO
                    };
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                    return null;
                }
            }
        }

        public static void ELIMINARPROVEEDOR(string codigo)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                var ELIMINA = BD.PROVEEDORESJABES23EIST6015
                    .SingleOrDefault(P => P.CODIGO == codigo);

                if (ELIMINA != null)
                {
                    BD.PROVEEDORESJABES23EIST6015.Remove(ELIMINA);
                    BD.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
        }

        public static void MODIFICARPROVEEDOR(
            string codigo,
            string nombres,
            string apellidos,
            string direccion,
            string ciudad,
            string telefono)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                var MODIFICA = BD.PROVEEDORESJABES23EIST6015
                    .SingleOrDefault(P => P.CODIGO == codigo);

                if (MODIFICA != null)
                {
                    MODIFICA.NOMBRES = nombres;
                    MODIFICA.APELLIDOS = apellidos;
                    MODIFICA.DIRECCION = direccion;
                    MODIFICA.CIUDAD = ciudad;
                    MODIFICA.TELEFONO = telefono;

                    BD.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
        }

        public static void INSERTARPROVEEDOR(
            string codigo,
            string nombres,
            string apellidos,
            string direccion,
            string ciudad,
            string telefono)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                BD.PROVEEDORESJABES23EIST6015.Add(new PROVEEDORESJABES23EIST6015
                {
                    CODIGO = codigo,
                    NOMBRES = nombres,
                    APELLIDOS = apellidos,
                    DIRECCION = direccion,
                    CIUDAD = ciudad,
                    TELEFONO = telefono
                });
                BD.SaveChanges();
            }
        }
    }

    internal class DATOSPROVEEDORES
    {
        public static List<PROVEEDORESJABES23EIST6015> MOSTRARDATOS()
        {
            using ( SCXPJABES23EIST6015Entities BD
 = new SCXPJABES23EIST6015Entities())
            {
                return (from P in BD.PROVEEDORESJABES23EIST6015
                        select P).ToList();
            }
        }

        public static List<PROVEEDORESJABES23EIST6015> BUSCARPORCODIGO(string codigo)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                return (from P in BD.PROVEEDORESJABES23EIST6015
                        where P.CODIGO.StartsWith(codigo)
                        select P).ToList();
            }
        }

        public static List<PROVEEDORESJABES23EIST6015> BUSCARNOMBRES(string nombres)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                return (from P in BD.PROVEEDORESJABES23EIST6015
                        where P.NOMBRES.StartsWith(nombres)
                        select P).ToList();
            }
        }

        public static List<PROVEEDORESJABES23EIST6015> BUSCARPORAPELLIDOS(string apellidos)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                return (from P in BD.PROVEEDORESJABES23EIST6015
                        where P.APELLIDOS.StartsWith(apellidos)
                        select P).ToList();
            }
        }

        public static List<PROVEEDORESJABES23EIST6015> BUSCARPORDIRECCION(string direccion)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                return (from P in BD.PROVEEDORESJABES23EIST6015
                        where P.DIRECCION.StartsWith(direccion)
                        select P).ToList();
            }
        }

        public static List<PROVEEDORESJABES23EIST6015> BUSCARPORCIUDAD(string ciudad)
        {
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                return (from P in BD.PROVEEDORESJABES23EIST6015
                        where P.CIUDAD.StartsWith(ciudad)
                        select P).ToList();
            }
        }
    }
}
