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
    class Shop
    {
        private Dictionary<Product, int> products; // словарь для хранения экземпляров класса Product и их количества

        public Shop() // конструктор класса Shop
        {
            products = new Dictionary<Product, int>();
        }
        public int GetProductCount(string productName)
        {
            Product product = FindByName(productName);
            if (product != null && products.ContainsKey(product))
            {
                return products[product];
            }
            return 0; // Если товар не найден, возвращаем 0
        }
        public Product FindByName(string name) // нахождение экземпляра класса по его имени в словаре products
        {
            foreach (var product in products.Keys)
            {
                if (product.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) // Сравнение без учета регистра
                {
                    return product;
                }
            }
            return null;
        }

        public void CreateProduct(string name, decimal price, int count) // создание экземпляра класса Product с последующим добавлением в словарь products 
        {
            products.Add(new Product(name, price), count);
        }

        public void WriteAllProducts(ListBox list) // вывод всех лежащих в словаре products продуктов в ListBox list
        {
            list.Items.Add("Список продуктов: ");
            foreach (var product in products)
            {
                list.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }

        public void Sell(Product product, TextBox txt) // уменьшение количества определённого продукта в словаре products
        {
            if (products.ContainsKey(product))
            {
                if (products[product] <= 0)
                {
                    MessageBox.Show("Нет в наличии!"); // Информируем пользователя
                }
                else
                {
                    products[product]--; // Уменьшаем количество товара
                    RestartStoncs(product.Price, txt); // Обновляем сумму проданных товаров
                    MessageBox.Show($"Товар '{product.Name}' продан. Осталось {products[product]} единиц.");
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!"); // Информируем пользователя
            }
        }

        public void Add(string ProductName, int count) // добавление count к количеству продуктов определённого класса
        {
            Product ToAdd = FindByName(ProductName);
            if (ToAdd == null)
            {
                MessageBox.Show("Товар не найден!"); // Информируем пользователя
            }
            else
            {
                products[ToAdd] += count;
            }
        }

        public void Sell(string ProductName, TextBox txt) // инициализация введённого класса и проверка найден ли он
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                // Проверка на наличие товара перед его продажей
                if (products[ToSell] > 0)
                {
                    this.Sell(ToSell, txt);
                }
                else
                {
                    MessageBox.Show("Недостаточно товара для продажи!"); // Информируем пользователя
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!"); // Информируем пользователя
            }
        }

        public void RestartStoncs(decimal price, TextBox txt) // нахождение всей суммы проданных товаров и вписывание суммы того что было и того что продано в textbox
        {
            decimal stoncs = decimal.Parse(txt.Text);
            stoncs += price;
            txt.Text = $"{stoncs}";
        }
    }
}
