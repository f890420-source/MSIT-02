using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MSIT_02.Data
{
    public class MSIT_02Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MSIT_02Context() : base("name=MSIT_02Context")
        {
        }

        public System.Data.Entity.DbSet<MSIT_02.Models.Entities.Level> Levels { get; set; }
    }
}
