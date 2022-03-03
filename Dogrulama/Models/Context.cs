using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Dogrulama.Models
{
    public class Context:DbContext
    {
        //public Context():base("Context")
        //{

        //}
        public DbSet<Kisi> Kisiler { get; set; }
    }
    
}

