//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CUENTAS_POR_PAGAR_JABES_23EIST6015
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHEQUESJABES23EIST6015
    {
        public int NUMEROCHEQUE { get; set; }
        public Nullable<int> NUMEROFACTURA { get; set; }
        public Nullable<decimal> VALORCHEQUE { get; set; }
        public Nullable<System.DateTime> FECHACHEQUE { get; set; }
    
        public virtual FACTURASJABES23EIST6015 FACTURASJABES23EIST6015 { get; set; }
    }
}
