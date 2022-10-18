using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Activos_Fijos_Apis.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public  DbSet<ACT_ALQUILER> ACT_ALQUILER { get; set; }
        public  DbSet<ACT_CATEGORIA> ACT_CATEGORIA { get; set; }
        public  DbSet<ACT_DEPARTAMENTO> ACT_DEPARTAMENTO { get; set; }
        public  DbSet<ACT_ESTADO> ACT_ESTADO { get; set; }
        public  DbSet<ACTIVO> ACTIVO { get; set; }
        public  DbSet<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public  DbSet<PROV_PRODUCTOS_DET> PROV_PRODUCTOS_DET { get; set; }
        public  DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public  DbSet<TIPO_CATEGORIA> TIPO_CATEGORIA { get; set; }
        public  DbSet<DET_ACTIVO> DET_ACTIVO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACT_ALQUILER>()
                .Property(e => e.ALQ_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ACT_ALQUILER>()
                .Property(e => e.ALQ_DESCRIPCION)
                .IsUnicode(false);


         

            modelBuilder.Entity<ACT_DEPARTAMENTO>()
                .Property(e => e.DEP_NOMBRE)
                .IsUnicode(false);

         

            modelBuilder.Entity<ACT_ESTADO>()
                .Property(e => e.act_nombre)
                .IsUnicode(false);

           

            modelBuilder.Entity<ACTIVO>()
                .Property(e => e.ACT_NOMBRE)
                .IsUnicode(false);

            

            

            modelBuilder.Entity<DETALLE_VENTA>()
                .Property(e => e.ven_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DETALLE_VENTA>()
                .Property(e => e.ven_precio)
                .HasPrecision(35, 2);

            modelBuilder.Entity<DETALLE_VENTA>()
                .Property(e => e.ven_descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PROV_PRODUCTOS_DET>()
                .Property(e => e.PROV_DET_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PROV_PRODUCTOS_DET>()
                .Property(e => e.PROV_DET_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PROV_PRODUCTOS_DET>()
                .Property(e => e.PROV_DET_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORES>()
                .Property(e => e.PROV_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORES>()
                .Property(e => e.PROV_NIT)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORES>()
                .Property(e => e.PROV_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORES>()
                .Property(e => e.PROV_CATEGORIA)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORES>()
                .Property(e => e.PROV_TELEFONO)
                .IsUnicode(false);

            

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.DP_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.DP_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.DP_FECHA_DE_VENCIMIENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.DP_DETALLES)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.DP_DISEÑO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ET_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ET_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ET_TIPO_DE_TRANSPORTE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ET_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ET_ANIO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.MOB_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.MO_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ACT_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.INM_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.INM_DIMENSIONES)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.INM_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ACT_MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ACT_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ACT_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.ACT_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.EF_MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.EF_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.EF_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.EF_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.MQ_FABRICANTE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.MQ_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.MQ_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CATEGORIA>()
                .Property(e => e.MQ_DESCRIPCION)
                .IsUnicode(false);

            

            modelBuilder.Entity<DET_ACTIVO>()
                .Property(e => e.ACT_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<DET_ACTIVO>()
                .Property(e => e.ACT_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<DET_ACTIVO>()
                .Property(e => e.ACT_FECHAINGRESO)
                .IsUnicode(false);

            modelBuilder.Entity<DET_ACTIVO>()
                .Property(e => e.ACT_PRECIO)
                .HasPrecision(10, 2);
        }
    }
}
