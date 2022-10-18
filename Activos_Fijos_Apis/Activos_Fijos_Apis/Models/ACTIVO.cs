namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACTIVO")]
    public partial class ACTIVO
    {
       /* [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVO()
        {
            DET_ACTIVO = new HashSet<DET_ACTIVO>();
            DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
        }*/

        [Key]
        public int ID_ACTIVO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACT_NOMBRE { get; set; }

        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DET_ACTIVO> DET_ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }*/
    }
}
