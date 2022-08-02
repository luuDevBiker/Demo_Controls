using System;
using System.Collections.Generic;

namespace Demo_Controls_UI.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? Title { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
    }
}
