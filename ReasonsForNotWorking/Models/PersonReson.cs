using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReasonsForNotWorking.Models
{
    public class PersonReson
    {
        public int PersonResonId { get; set; }
        public string PersonName { get; set; }
        public int ReasonId { get; set; }
        public DateTime Date { get; set; }
    }
}