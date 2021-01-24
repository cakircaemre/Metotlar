using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //Ürün Id si

        public int CategoryId { get; set; } // Ürün kategorsi
        public string ProductName { get; set; } // Ürün Adı
        public double UnitPrice { get; set; } //Ürün fiyatı

        public int UnitsInStock { get; set; } //Ürün stok adedi


    }
}
