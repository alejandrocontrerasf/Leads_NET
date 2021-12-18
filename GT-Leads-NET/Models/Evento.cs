using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GT_Leads_NET.Models
{
    public class Evento
    {
        [Key]
         public int ID { get; set; }

        [Required(ErrorMessage = "Error: El Nombre es requerido")]
        [Display(Name = "Nombre Evento")]
        public string NombreEvento { get; set; }

        [Required(ErrorMessage = "Error: La fecha de inicio es requerida")]
        [Display(Name = "Fecha Inicio")]
        [DataType(DataType.Date)]
        public DateTime  FechaInicio { get; set; }

        [Required(ErrorMessage = "Error: La fecha de fin es requerida")]
        [Display(Name = "Fecha Fin")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

            [Required(ErrorMessage = "Error: La ciudad es requerida")]
            public string Ciudad { get; set; }
        }
    }
