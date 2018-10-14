using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerWebService.Models
{
    [Table("Publicacion")]
    public class Publicacion
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }
        [MaxLength(250)]
        [Required]
        public string Descripccion { get; set; }
        public DateTime FechaPublicaion { get; set; }
        public int MeGusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }
    }
}