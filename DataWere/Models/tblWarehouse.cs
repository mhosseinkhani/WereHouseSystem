﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWere.Models
{
    public class tblWarehouse
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public bool status { get; set; }

    }
}