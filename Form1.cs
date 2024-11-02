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
    public partial class Form1 : Form
    {
        private Shop shop = new Shop();

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateProductBtn_Click(object sender, EventArgs e)
        {
            PanelCreateProduct.Visible = true;
            SellProductPanel.Visible = false;
            AddProductPanel.Visible = false;
        }
        private void SellProductBtn_Click(object sender, EventArgs e)
        {
            SellProductPanel.Visible = true;
            PanelCreateProduct.Visible = false;
            AddProductPanel.Visible = false;
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductPanel.Visible = true;
            PanelCreateProduct.Visible = false;
            SellProductPanel.Visible = false;
        }
        private void StartCreateProductBtn_Click(object sender, EventArgs e)
        {
            if (EnterValueOk(CreateProductName.Text, CreateProductCount.Text, CreateProductPrice.Text))
            {
                if (shop.FindByName(CreateProductName.Text) == null)
                {
                    shop.CreateProduct(CreateProductName.Text, decimal.Parse(CreateProductPrice.Text), int.Parse(CreateProductCount.Text));
                }
                else
                {
                    MessageBox.Show("Такой товар уже добавлен");
                }
            }
            listBoxProducts.Items.Clear();
            shop.WriteAllProducts(listBoxProducts);
            PanelCreateProduct.Visible = false;
        }
        private void StartSellProductBtn_Click(object sender, EventArgs e)
        {
            if (EnterValueOk(SellProductName.Text, SellProductCount.Text)) // Проверка корректности ввода
            {
                string productName = SellProductName.Text; // Имя товара
                int count = int.Parse(SellProductCount.Text); // Преобразование введенного количества в число

                // Получаем количество товара с помощью нового метода
                int availableCount = shop.GetProductCount(productName);

                if (availableCount >= count) // Проверка, достаточно ли товара для продажи
                {
                    for (int i = 0; i < count; i++)
                    {
                        shop.Sell(productName, textBoxStoncs); // Продажа товара
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточно товара для продажи!"); // Информируем пользователя
                }
            }

            // Обновляем список продуктов
            listBoxProducts.Items.Clear();
            shop.WriteAllProducts(listBoxProducts);
        }
        private void StartAddProductBtn_Click(object sender, EventArgs e)
        {
            if (EnterValueOk(AddProductName.Text, AddProductCount.Text, CreateProductPrice.Text))
            {
                shop.Add(AddProductName.Text, int.Parse(AddProductCount.Text));
            }
            listBoxProducts.Items.Clear();
            shop.WriteAllProducts(listBoxProducts);
            PanelCreateProduct.Visible = false;

        }
        public bool EnterValueOk(string name, string count) // проверка правильности ввода данных в 2 строк
        {
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Неверный ввод в поле имени");
                    return false;
                }
            }
            foreach (char ch in count)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Неверный ввод в поле количества");
                    return false;
                }
            }
            return true;

        }
        public bool EnterValueOk(string name, string count, string price = "100") // проверка правильности ввода данных в 3 строки, перегрузка EnterValueOk(string name, string count)
        {
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Неверный ввод в поле имени");
                    return false;
                }
            }
            foreach (char ch in price)
            {
                if (!char.IsDigit(ch))
                {
                    if (ch == ',')
                    {

                    }
                    else
                    {
                        MessageBox.Show("Неверный ввод в поле цены");
                        return false;
                    }
                }
            }
            foreach (char ch in count)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Неверный ввод в поле количества");
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
