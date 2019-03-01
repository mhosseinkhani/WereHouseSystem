using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWere.Models
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