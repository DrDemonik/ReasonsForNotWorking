using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ReasonsForNotWorking.Models
{
    public class ReasonDbInitializer: DropCreateDatabaseAlways<ReasonContext>
    {
        //public override void InitializeDatabase(ReasonContext db)
        //{
        //    db.Reasons.Add(new Reason { Name = "Нет развития", idType = 1 });
        //    db.Reasons.Add(new Reason { Name = "Строгий контроль", idType = 2 });
        //    db.Reasons.Add(new Reason { Name = "LEgasi код", idType = 3 });
        //    base.InitializeDatabase(db);
        //}

        protected override void Seed(ReasonContext db)
        {
            db.Reasons.Add(new Reason { Name = "Нет развития", idType = 1 });
            db.Reasons.Add(new Reason { Name = "Строгий контроль", idType = 2 });
            db.Reasons.Add(new Reason { Name = "LEgasi код", idType = 3 });
            base.Seed(db);
        }
    }
}