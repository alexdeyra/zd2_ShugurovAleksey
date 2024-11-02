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
        private Shop shop = new Shop(); // Создание экземпляра класса Shop для управления продуктами

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateProductBtn_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки создания продукта
        {
            PanelCreateProduct.Visible = true;
            SellProductPanel.Visible = false;
            AddProductPanel.Visible = false;
        }
        private void SellProductBtn_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки продажи продукта
        {
            SellProductPanel.Visible = true;
            PanelCreateProduct.Visible = false;
            AddProductPanel.Visible = false;
        }
        private void AddProductBtn_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки добавления продукта
        {
            AddProductPanel.Visible = true;
            PanelCreateProduct.Visible = false;
            SellProductPanel.Visible = false;
        }
        private void StartCreateProductBtn_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки для начала создания продукта
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
        private void StartSellProductBtn_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки для продажи продукта
        {
            // Проверка корректности ввода
            if (string.IsNullOrWhiteSpace(SellProductName.Text) || string.IsNullOrWhiteSpace(SellProductCount.Text))
            {
                MessageBox.Show("Пожалуйста, введите товары и их количество.");
                return;
            }

            // Разделяем введенные данные по точке с запятой
            string[] productsToSell = SellProductName.Text.Split(';');
            string[] countsToSell = SellProductCount.Text.Split(';');

            if (productsToSell.Length != countsToSell.Length)
            {
                MessageBox.Show("Количество товаров и их количеств должно совпадать.");
                return;
            }

            for (int i = 0; i < productsToSell.Length; i++)
            {
                string productName = productsToSell[i].Trim(); // Убираем лишние пробелы
                if (int.TryParse(countsToSell[i].Trim(), out int count)) // Преобразуем количество
                {
                    // Получаем количество товара с помощью нового метода
                    int availableCount = shop.GetProductCount(productName);

                    if (availableCount >= count) // Проверка, достаточно ли товара для продажи
                    {
                        for (int j = 0; j < count; j++)
                        {
                            shop.Sell(productName, textBoxStoncs); // Продажа товара
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Недостаточно товара '{productName}' для продажи!"); // Информируем пользователя
                    }
                }
                else
                {
                    MessageBox.Show($"Неверное количество для товара '{productName}'."); // Информируем пользователя
                }
            }

            // Обновляем список продуктов
            listBoxProducts.Items.Clear();
            shop.WriteAllProducts(listBoxProducts);
        }
        private void StartAddProductBtn_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки для добавления продукта
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
