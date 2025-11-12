using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLearning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PhoneSale> sales = new List<PhoneSale>();

            Dictionary<string, double> phonePrices = new Dictionary<string, double>();
            phonePrices.Add("iPhone 15", 999.99);
            phonePrices.Add("Samsung Galaxy S24", 899.99);
            phonePrices.Add("Google Pixel 8", 799.99);
            phonePrices.Add("Xiaomi 14", 699.99);
            phonePrices.Add("OnePlus 12", 749.99);
            phonePrices.Add("Huawei P60", 649.99);
            phonePrices.Add("Nokia G60", 299.99);
            phonePrices.Add("Motorola Edge 40", 449.99);

            AddSale(sales, phonePrices, new DateTime(2025, 11, 1), "iPhone 15", 5);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 3), "Samsung Galaxy S24", 3);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 3), "iPhone 15", 2);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 4), "Google Pixel 8", 4);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 6), "Samsung Galaxy S24", 6);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 7), "Xiaomi 14", 3);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 7), "iPhone 15", 1);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 9), "Nokia G60", 8);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 11), "OnePlus 12", 4);
            AddSale(sales, phonePrices, new DateTime(2025, 11, 11), "Huawei P60", 2);

            // Период анализа
            DateTime startDate = new DateTime(2025, 11, 1);
            DateTime endDate = new DateTime(2025, 11, 11);
        }
    }
}
