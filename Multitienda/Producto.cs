namespace Multitienda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProducto { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public int idCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
