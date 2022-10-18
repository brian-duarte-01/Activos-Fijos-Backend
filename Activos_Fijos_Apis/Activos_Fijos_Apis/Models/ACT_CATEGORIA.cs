namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACT_CATEGORIA
    {
        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACT_CATEGORIA()
        {
            DET_ACTIVO = new HashSet<DET_ACTIVO>();
        }*/

        [Key]
        public int ID_CATEGORIA { get; set; }

        public int ID_TIPO_CATEGORIA { get; set; }

        /*public virtual TIPO_CATEGORIA TIPO_CATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DET_ACTIVO> DET_ACTIVO { get; set; }*/
    }
}
