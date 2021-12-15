using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }

}
