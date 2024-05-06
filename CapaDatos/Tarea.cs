using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Tarea
    {
        [Key]
        public Guid TareaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Guid CategoriaId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        // una propiedad virtual permite que la propiedad sea sobrescrita en clases derivadas (subclases) utilizando la palabra clave override
        public virtual Categoria Categoria { get; set; }

        // En el momento que se haga el mapeo hacia la base de datos el omite este campo
        //[NotMapped]
        public string Resumen { get; set; }
    }
}
