﻿namespace Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public bool IsRefunded { get; set; }
        public virtual Course? Course { get; set; }
    }
}
