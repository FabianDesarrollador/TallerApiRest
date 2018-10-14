using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerWebService.Models
{
    public class PublicacionContext : DbContext
    {
        public PublicacionContext() : base("Publicationconection")
        {

        }

        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}