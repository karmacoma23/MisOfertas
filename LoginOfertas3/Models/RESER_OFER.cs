//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginOfertas3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESER_OFER
    {
        public decimal RESE_ID { get; set; }
        public System.DateTime RESE_FECHA { get; set; }
        public decimal RESER_ESTADO_ESTADO_ID { get; set; }
        public decimal OFERTA_OFER_ID { get; set; }
        public string USUARIO_USER_ID { get; set; }
    
        public virtual OFERTA OFERTA { get; set; }
        public virtual RESER_ESTADO RESER_ESTADO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
