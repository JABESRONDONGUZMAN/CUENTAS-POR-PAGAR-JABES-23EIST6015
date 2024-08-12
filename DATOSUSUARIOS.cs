using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR_JABES_23EIST6015
{
    internal class DATOSUSUARIOS
    {
        public static List<USUARIOSJABES23EIST6015> MOSTRAR()
        {
            /* Usamos LINQ para obtener todos los usuarios. */
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                var INFO = (from U in BD.USUARIOSJABES23EIST6015
                            select U).ToList();
                return INFO;
            }
        }

        public static List<USUARIOSJABES23EIST6015> BUSCARPORUSUARIO(string usuario)
        {
            /* Usamos LINQ para buscar un usuario por nombre, empezando con cualquier letra. */
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                var INFO = (from U in BD.USUARIOSJABES23EIST6015
                            where U.USUARIO.StartsWith(usuario)
                            select U).ToList();
                return INFO;
            }
        }

        public static List<USUARIOSJABES23EIST6015> BUSCARPORCLAVE(string clave)
        {
            /* Usamos LINQ para buscar un usuario por clave, empezando con cualquier letra. */
            using (var BD = new SCXPJABES23EIST6015Entities())
            {
                var INFO = (from U in BD.USUARIOSJABES23EIST6015
                            where U.CLAVE.StartsWith(clave)
                            select U).ToList();
                return INFO;
            }
        }
    }
}
