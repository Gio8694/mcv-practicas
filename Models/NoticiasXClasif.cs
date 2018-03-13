using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noticiero.Models
{
    public class NoticiasXClasif
    {

        public int NoticiaID { get; set; }
       
        public int ClasifID { get; set; }
       
        public string Titulo { get; set; }
       
        public string Contenido { get; set; }
        
        public string Autor { get; set; }
        
        public DateTime FechaNoticia { get; set; }
        
        public string Foto { get; set; }

        public string Nombre { get; set; }
    }
}