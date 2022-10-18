namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROV_PRODUCTOS_DET
    {
        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROV_PRODUCTOS_DET()
        {
            PROVEEDORES = new HashSet<PROVEEDORES>();
        }*/

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PROV_PRODUCTOS { get; set; }

        [Required]
        [StringLength(100)]
        public string PROV_DET_NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string PROV_DET_TIPO { get; set; }

        [StringLength(100)]
        public string PROV_DET_DESCRIPCION { get; set; }

        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDORES> PROVEEDORES { get; set; }*/
    }
}
