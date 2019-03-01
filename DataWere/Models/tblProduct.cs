using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWere.Models
{
    public class tblProduct
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string number { get; set; }
        public string description { get; set; }
        public int idunit { get; set; }
        public int minquantity { get; set; }
        public DateTime datecreated { get; set; }
        public bool status { get; set; }

        public decimal partnerPrice { get; set; }
        public decimal price { get; set; }
        public decimal cashDiscount { get; set; }
        public string paymentDeadline { get; set; }
        public decimal frieghtCost { get; set; }
        public decimal profit { get; set; }
        public byte profitPercent { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime expiredOn { get; set; }
        public int expireDay { get; set; }
        public DateTime firstBuyedOn { get; set; }
        public DateTime lastBuyedOn { get; set; }

        public int buyedQty { get; set; }
        public int buyedTotal { get; set; }

    }
}