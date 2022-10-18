namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACT_ALQUILER
    {
       /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACT_ALQUILER()
        {
            DET_ACTIVO = new HashSet<DET_ACTIVO>();
        }*/

        [Key]
        public int ID_CONTRATO { get; set; }

        public int ID_PROVEEDOR { get; set; }

        [Required]
        [StringLength(50)]
        public string ALQ_ESTADO { get; set; }

        [Required]
        [StringLength(100)]
        public string ALQ_DESCRIPCION { get; set; }

        [Column(TypeName = "date")]
        public DateTime ALQ_FECHA_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime ALQ_FECHA_FIN { get; set; }

       /* public virtual PROVEEDORES PROVEEDORES { get; set; }/*

        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DET_ACTIVO> DET_ACTIVO { get; set; }*/
    }
}
