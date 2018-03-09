using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Noticiero.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        [Required]
        public int ClasifID { get; set; }
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Contenido { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        [Display(Name ="Fecha de Noticia")]
        public DateTime FechaNoticia { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public int Estado { get; set; }

        public virtual Clasif Clasifs { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Noticia()
        {
            FechaNoticia = DateTime.Now;
        }
    }
}