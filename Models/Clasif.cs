using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Noticiero.Models
{
    public class Clasif
    {
        public int ClasifID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Nombre de Clasificacion")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name ="Fecha de Creacion")]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public int Estado { get; set; }

        public virtual ICollection<Noticia> Noticias { get; set; }

        public Clasif() {
            FechaCreacion = DateTime.Now;
        }
    }
}