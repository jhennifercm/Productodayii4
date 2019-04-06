using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Apiparcial2.Models
{
    public class DataContext:DbContext

    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Apiparcial2.Models.Product> Products { get; set; }
    }
}
