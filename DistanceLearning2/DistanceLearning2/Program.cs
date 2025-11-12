using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLearning2
{
    internal class Program
    {
        static void Main()
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

            // a) Общая сумма проданного за период
            double totalAmount = CalculateTotalSales(sales, startDate, endDate);
            Console.WriteLine("a) Общая сумма продаж за период: " + totalAmount.ToString("F2") + " руб.");

            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            List<string> models = new List<string>();
            List<int> quantities = new List<int>();
            for (int i = 0; i < sales.Count; i++)  // Заполнение списков данными о продажах
            {
                string currentModel = sales[i].PhoneModel;
                int currentQuantity = sales[i].Quantity;
                bool found = false;           
                for (int j = 0; j < models.Count; j++) // Поиск моделей в списке
                {
                    if (models[j] == currentModel)
                    {
                        quantities[j] = quantities[j] + currentQuantity;
                        found = true;
                        break;
                    }
                }
                if (!found) // Если модель не найдена, добавляем новую
                {
                    models.Add(currentModel);
                    quantities.Add(currentQuantity);
                }
            }
            string bestPhone = FindBestSellingPhone(models, quantities);
            Console.WriteLine("б) Самый продаваемый телефон: " + bestPhone); // Вывод на консоль самого продаваемого телефона


            // в) Два телефона, приносящие наибольшую прибыль
            List<string> profitModels = new List<string>();
            List<double> profits = new List<double>();
            for (int i = 0; i < sales.Count; i++)
            {
                string currentModel = sales[i].PhoneModel;
                double currentProfit = sales[i].TotalAmount;

                bool found = false;
                // Ищем модель в списке
                for (int j = 0; j < profitModels.Count; j++)
                {
                    if (profitModels[j] == currentModel)
                    {
                        profits[j] = profits[j] + currentProfit;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    profitModels.Add(currentModel);
                    profits.Add(currentProfit);
                }
            }
            

        }
}
