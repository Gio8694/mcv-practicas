using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Noticiero.Models
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        [Required]
        public int NoticiaID { get; set; }
        [StringLength(100)]
        [Display(Name ="Titulo")]
        public string TituloComen { get; set; }
        [Required]
        [Display(Name ="Contenido")]
        [DataType(DataType.MultilineText)]
        public string ContenidoComen { get; set; }
        [Required]
        [Display(Name ="Autor")]
        public string AutorComen { get; set; }
        [Required]
        [Display(Name ="Fecha Comentario")]
        public DateTime FechaComen { get; set; }

        public virtual Noticia Noticias { get; set; }

        public Comentario()
        {
            FechaComen = DateTime.Now;
        }
    }
}