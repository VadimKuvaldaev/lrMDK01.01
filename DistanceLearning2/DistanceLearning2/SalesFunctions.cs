using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLearning2
{
    public class SalesFunctions
    {
        public static Dictionary<string, double> InitializePhonePrices() // Функция инициализации цен
        {
            Dictionary<string, double> phonePrices = new Dictionary<string, double>(); 
            phonePrices.Add("iPhone 15", 999.99); 
            phonePrices.Add("Samsung Galaxy S24", 899.99); 
            phonePrices.Add("Google Pixel 8", 799.99); 
            phonePrices.Add("Xiaomi 14", 699.99); 
            phonePrices.Add("OnePlus 12", 749.99); 
            phonePrices.Add("Huawei P60", 649.99); 
            phonePrices.Add("Nokia G60", 299.99); 
            phonePrices.Add("Motorola Edge 40", 449.99); 
            return phonePrices; 
        }
        public static double CalculateTotalAmount(int quantity, double price) // Функция вычисления общей суммы
        {
            return quantity * price; 
        }
        public static void AddSale(List<PhoneSale> sales, Dictionary<string, double> phonePrices, DateTime date, string phoneModel, int quantity) // Функция добавления продажи
        {
            double price = 500.00; // Установка цены по умолчанию
            if (phonePrices.ContainsKey(phoneModel)) // Проверка наличия модели в словаре цен
            {
                price = phonePrices[phoneModel]; 
            }
            PhoneSale sale = new PhoneSale(); 
            sale.Date = date; 
            sale.PhoneModel = phoneModel; 
            sale.Quantity = quantity; 
            sale.Price = price; 
            sale.TotalAmount = CalculateTotalAmount(quantity, price); // Вычисление общей суммы

            sales.Add(sale); // Добавление продажи в список
        }

    }
}
