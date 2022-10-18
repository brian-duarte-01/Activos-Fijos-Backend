namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_CATEGORIA
    {
        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_CATEGORIA()
        {
            ACT_CATEGORIA = new HashSet<ACT_CATEGORIA>();
        }*/

        [Key]
        public int ID_TIPO_CATEGORIA { get; set; }

        [Required]
        [StringLength(50)]
        public string DP_NOMBRE { get; set; }

        [Required]
        [StringLength(15)]
        public string DP_SERIE { get; set; }

        [Required]
        [StringLength(10)]
        public string DP_FECHA_DE_VENCIMIENTO { get; set; }

        [Required]
        [StringLength(100)]
        public string DP_DETALLES { get; set; }

        [Required]
        [StringLength(50)]
        public string DP_DISEÑO { get; set; }

        [Required]
        [StringLength(50)]
        public string ET_NOMBRE { get; set; }

        [Required]
        [StringLength(10)]
        public string ET_PLACA { get; set; }

        [Required]
        [StringLength(20)]
        public string ET_TIPO_DE_TRANSPORTE { get; set; }

        [Required]
        [StringLength(10)]
        public string ET_SERIE { get; set; }

        [Required]
        [StringLength(5)]
        public string ET_ANIO { get; set; }

        [Required]
        [StringLength(50)]
        public string MOB_NOMBRE { get; set; }

        [Required]
        [StringLength(100)]
        public string MO_DESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string ACT_NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string INM_NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string INM_DIMENSIONES { get; set; }

        [Required]
        [StringLength(50)]
        public string INM_DIRECCION { get; set; }

        [Required]
        [StringLength(50)]
        public string ACT_MARCA { get; set; }

        [Required]
        [StringLength(50)]
        public string ACT_MODELO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACT_SERIE { get; set; }

        [Required]
        [StringLength(100)]
        public string ACT_DESCRIPCION { get; set; }

        [Required]
        [StringLength(10)]
        public string EF_MARCA { get; set; }

        [Required]
        [StringLength(50)]
        public string EF_TIPO { get; set; }

        [Required]
        [StringLength(50)]
        public string EF_MODELO { get; set; }

        [Required]
        [StringLength(100)]
        public string EF_DESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string MQ_FABRICANTE { get; set; }

        [Required]
        [StringLength(50)]
        public string MQ_TIPO { get; set; }

        [Required]
        [StringLength(50)]
        public string MQ_MODELO { get; set; }

        [Required]
        [StringLength(50)]
        public string MQ_DESCRIPCION { get; set; }

        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACT_CATEGORIA> ACT_CATEGORIA { get; set; }*/
    }
}
