using System.Collections.Generic;
using DataWere.Models;

namespace DataWere.ViewModels
{
    public class ProductViewModel
    {
        public tblProduct Product { get; set; }
        public IEnumerable<tblUnit> Units { get; set; }
        public string unit { get; set; }

    }
}