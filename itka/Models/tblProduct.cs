using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace itka.Models
{
    public class tblProduct
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string description { get; set; }
        public int idunit { get; set; }
        public int minquantity { get; set; }
        public DateTime datecreated { get; set; }
        public bool status { get; set; }

    }
}