using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLearning2
{
    internal class Program
    {
        public static void AddSale(List<PhoneSale> sales, Dictionary<string, double> prices, DateTime date, string model, int quantity)
        {
            PhoneSale sale = new PhoneSale();
            sale.Date = date;
            sale.PhoneModel = model;
            sale.Quantity = quantity;

            if (prices.ContainsKey(model))
            {
                sale.Price = prices[model];
            }
            else
            {
                sale.Price = 500.00;
            }

            sale.TotalAmount = sale.Quantity * sale.Price;
            sales.Add(sale);
        }

        public static double CalculateTotalSales(List<PhoneSale> sales, DateTime startDate, DateTime endDate)
        {
            double total = 0;
            for (int i = 0; i < sales.Count; i++)
            {
                if (sales[i].Date >= startDate && sales[i].Date <= endDate)
                {
                    total = total + sales[i].TotalAmount;
                }
            }
            return total;
        }

        public static string FindBestSellingPhone(List<string> models, List<int> quantities)
        {
            string bestPhone = "Нет данных";
            int maxCount = 0;

            for (int i = 0; i < models.Count; i++)
            {
                if (quantities[i] > maxCount)
                {
                    maxCount = quantities[i];
                    bestPhone = models[i];
                }
            }
            return bestPhone;
        }

        public static string FindWorstSellingPhone(List<string> models, List<int> quantities)
        {
            string worstPhone = "Нет данных";
            int minCount = 1000000;

            for (int i = 0; i < models.Count; i++)
            {
                if (quantities[i] < minCount)
                {
                    minCount = quantities[i];
                    worstPhone = models[i];
                }
            }
            return worstPhone;
        }

        public static void PrintDailySales(List<PhoneSale> sales, DateTime startDate, DateTime endDate)
        {
            Console.WriteLine();
            Console.WriteLine("   Продажи по дням   ");

            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < sales.Count; i++)
            {
                if (sales[i].Date >= startDate && sales[i].Date <= endDate)
                {
                    DateTime dateOnly = sales[i].Date.Date;
                    bool found = false;

                    for (int j = 0; j < dates.Count; j++)
                    {
                        if (dates[j] == dateOnly)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        dates.Add(dateOnly);
                    }
                }
            }

            for (int i = 0; i < dates.Count - 1; i++)
            {
                for (int j = i + 1; j < dates.Count; j++)
                {
                    if (dates[i] > dates[j])
                    {
                        DateTime temp = dates[i];
                        dates[i] = dates[j];
                        dates[j] = temp;
                    }
                }
            }

            for (int i = 0; i < dates.Count; i++)
            {
                double dayTotal = 0;
                int dayCount = 0;

                for (int j = 0; j < sales.Count; j++)
                {
                    if (sales[j].Date.Date == dates[i])
                    {
                        dayTotal = dayTotal + sales[j].TotalAmount;
                        dayCount = dayCount + sales[j].Quantity;
                    }
                }

                Console.WriteLine(dates[i].ToString("dd.MM.yyyy") + ": " + dayCount + " телефонов на сумму " + dayTotal.ToString("F2") + " руб.");
            }
        }
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

            // Заполнение списков данными о продажах
            for (int i = 0; i < sales.Count; i++)
            {
                string currentModel = sales[i].PhoneModel;
                int currentQuantity = sales[i].Quantity;
                bool found = false;

                // Поиск моделей в списке
                for (int j = 0; j < models.Count; j++)
                {
                    if (models[j] == currentModel)
                    {
                        quantities[j] = quantities[j] + currentQuantity;
                        found = true;
                        break;
                    }
                }

                // Если модель не найдена, добавляем новую
                if (!found)
                {
                    models.Add(currentModel);
                    quantities.Add(currentQuantity);
                }
            }

            string bestPhone = FindBestSellingPhone(models, quantities);
            Console.WriteLine("б) Самый продаваемый телефон: " + bestPhone);

            string worstPhone = FindWorstSellingPhone(models, quantities);
            Console.WriteLine("   Телефон с наименьшими продажами: " + worstPhone);

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

            string firstProfitPhone = "";
            double firstProfit = 0;
            for (int i = 0; i < profitModels.Count; i++)
            {
                if (profits[i] > firstProfit)
                {
                    firstProfit = profits[i];
                    firstProfitPhone = profitModels[i];
                }
            }

            string secondProfitPhone = "";
            double secondProfit = 0;
            for (int i = 0; i < profitModels.Count; i++)
            {
                if (profits[i] > secondProfit && profitModels[i] != firstProfitPhone)
                {
                    secondProfit = profits[i];
                    secondProfitPhone = profitModels[i];
                }
            }

            Console.WriteLine("в) Два телефона, приносящие наибольшую прибыль:");
            Console.WriteLine("   1. " + firstProfitPhone);
            Console.WriteLine("   2. " + secondProfitPhone);

            PrintDailySales(sales, startDate, endDate);

            Console.WriteLine();
            Console.WriteLine("   Временной ряд продаж   ");
            for (int i = 0; i < sales.Count; i++)
            {
                if (sales[i].Date >= startDate && sales[i].Date <= endDate)
                {
                    Console.WriteLine(sales[i].Date.ToString("dd.MM.yyyy") + " - " +
                        sales[i].PhoneModel + ": " + sales[i].Quantity + " шт. × " +
                        sales[i].Price.ToString("F2") + " руб. = " +
                        sales[i].TotalAmount.ToString("F2") + " руб.");
                }
            }
        }
    }
}

