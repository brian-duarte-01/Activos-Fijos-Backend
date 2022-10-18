namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROVEEDORES
    {
       /* [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDORES()
        {
            ACT_ALQUILER = new HashSet<ACT_ALQUILER>();
        }¨*/

        [Key]
        public int ID_PROVEEDOR { get; set; }

        [Required]
        [StringLength(50)]
        public string PROV_NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string PROV_NIT { get; set; }

        [Required]
        [StringLength(100)]
        public string PROV_DIRECCION { get; set; }

        [Required]
        [StringLength(50)]
        public string PROV_CATEGORIA { get; set; }

        [StringLength(15)]
        public string PROV_TELEFONO { get; set; }

        public int? PROV_PRODUCTOS { get; set; }

/*        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACT_ALQUILER> ACT_ALQUILER { get; set; }

        public virtual PROV_PRODUCTOS_DET PROV_PRODUCTOS_DET { get; set; } */
    }
}
