using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWere.Models
{
    public class tblUnit
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool status { get; set; }

    }
}