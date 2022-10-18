namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACT_DEPARTAMENTO
    {
        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACT_DEPARTAMENTO()
        {
            DET_ACTIVO = new HashSet<DET_ACTIVO>();
        }*/

        [Key]
        public int ID_DEPARTAMENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string DEP_NOMBRE { get; set; }

        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DET_ACTIVO> DET_ACTIVO { get; set; }*/
    }
}
