using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace itka.Models
{
    public class tblExit
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public bool status { get; set; }
    }
}