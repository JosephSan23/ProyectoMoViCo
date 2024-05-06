﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int Peso { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
