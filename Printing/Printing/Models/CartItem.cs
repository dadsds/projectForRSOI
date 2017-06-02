using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Printing.Models
{
    public class CartItem
    {
        [DisplayName("Название товара")]
        public string ItemName { get; set; }
        [DisplayName("Количество")]
        public int Quantity { get; set; }
        [DisplayName("Цена за 1 шт.")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Итог")]
        public decimal TotalPrice { get; set; }
    }
}
