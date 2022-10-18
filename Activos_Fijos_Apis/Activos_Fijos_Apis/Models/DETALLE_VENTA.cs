namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DETALLE_VENTA
    {
        [Key]
        public int id_detalle_venta { get; set; }

        [Required]
        [StringLength(1000)]
        public string ven_nombre { get; set; }

        public decimal ven_precio { get; set; }

        public int ven_cantidad { get; set; }

        [Required]
        [StringLength(500)]
        public string ven_descripcion { get; set; }

        public int id_activo { get; set; }

       /* public virtual ACTIVO ACTIVO { get; set; } */
    }
}
