using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ReasonsForNotWorking.Models
{
    public class ReasonContext: DbContext
    {
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<PersonReson> PersonResons { get; set; }
    }
}