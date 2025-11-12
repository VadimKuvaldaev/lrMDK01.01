using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLearning2
{
    public class SalesFunctions
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
    }
}
