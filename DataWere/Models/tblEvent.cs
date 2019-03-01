using System.ComponentModel.DataAnnotations;

namespace DataWere.Models
{
    public class tblEvent
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
    }
}