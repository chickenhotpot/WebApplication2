using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<WebApplication1.Models.Xueshengxinxi> Xueshengxinxis { get; set; }

        public DbSet<WebApplication1.Models.Chengji> Chengjis { get; set; }

       // public System.Data.Entity.DbSet<WebApplication1.Models.Chengji> Chengjis { get; set; }
    }
}