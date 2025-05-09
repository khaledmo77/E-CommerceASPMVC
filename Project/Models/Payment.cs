﻿namespace Project.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual Order? Order { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
    }
}
