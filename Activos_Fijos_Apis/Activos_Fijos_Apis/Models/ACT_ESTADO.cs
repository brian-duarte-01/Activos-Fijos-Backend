namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACT_ESTADO
    {
       /* [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACT_ESTADO()
        {
            DET_ACTIVO = new HashSet<DET_ACTIVO>();
        }*/

        [Key]
        public int id_estado { get; set; }

        [StringLength(1000)]
        public string act_nombre { get; set; }

       /* [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DET_ACTIVO> DET_ACTIVO { get; set; }*/
    }
}
