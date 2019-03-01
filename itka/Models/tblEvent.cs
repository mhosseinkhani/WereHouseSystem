using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace itka.Models
{
    public class tblEvent
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
    }
}