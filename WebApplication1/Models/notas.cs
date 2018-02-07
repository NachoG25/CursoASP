namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class notas
    {
        [Key]
        public int idnotas { get; set; }

        [StringLength(500)]
        public string texto { get; set; }

        public int? notas_usuario_fk { get; set; }

        public virtual usuarios usuarios { get; set; }
    }
}
