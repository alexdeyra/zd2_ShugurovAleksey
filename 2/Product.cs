using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    class Product
    {
        public decimal Price { get; set; } // свойство переменное Price
        public string Name { get; set; }// свойство переменное Name
        public Product(string Name, decimal Price) // конструктор класса
        {
            this.Name = Name;
            this.Price = Price;
        }
        public string GetInfo()// вывод информации о данном классе
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}
