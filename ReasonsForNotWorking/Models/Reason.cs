using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReasonsForNotWorking.Models
{
    public class Reason
    {        
        public int ReasonId { get; set; }
        public string Name { get; set; }
        public int idType { get; set; }
    }
}