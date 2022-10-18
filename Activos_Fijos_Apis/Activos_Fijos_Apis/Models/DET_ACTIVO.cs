namespace Activos_Fijos_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DET_ACTIVO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int ID_DETALLE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ACT_SERIE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ACT_NOMBRE { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ACTIVO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ACT_FECHAINGRESO { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ACT_PRECIO { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONTRATO { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CATEGORIA { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ESTADO { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_DEPARTAMENTO { get; set; }

      /* public virtual ACT_ALQUILER ACT_ALQUILER { get; set; }

        public virtual ACT_CATEGORIA ACT_CATEGORIA { get; set; }

        public virtual ACT_DEPARTAMENTO ACT_DEPARTAMENTO { get; set; }

        public virtual ACT_ESTADO ACT_ESTADO { get; set; }

        public virtual ACTIVO ACTIVO { get; set; }*/
    }
}
