using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GT_Leads_NET.Models
{
    public class Lead
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Error: El Nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Error: El Telefono es requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Error: El Correo es requerido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Error: La Ciudad es requerida")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Error: El evento es requerido")]
        public string Evento { get; set; }
    }

}
