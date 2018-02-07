namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            notas = new HashSet<notas>();
        }

        [Key]
        public int idusuarios { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(500)]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [StringLength(500)]
        public string apellido { get; set; }

        [Required]
        [Display(Name = "Nombre de Usuario")]
        [StringLength(500)]     
        public string nameuser { get; set; }

        [Required]
        [Display(Name = "Contrase�a")]
        [StringLength(500, MinimumLength = 8, ErrorMessage = "Debe ingresar minimo 8 caracteres")]
        [DataType(DataType.Password)]
        public string pw { get; set; }


        public string loginErrorMensaje { get; set;}

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notas> notas { get; set; }
    }
}
