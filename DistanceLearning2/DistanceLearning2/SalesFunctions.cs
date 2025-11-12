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
        public static void AddSale(List<PhoneSale> sales, Dictionary<string, double> prices, DateTime date, string model, int quantity) // Функция добавления продажи
        {
            PhoneSale sale = new PhoneSale();
            sale.Date = date;
            sale.PhoneModel = model;
            sale.Quantity = quantity;

            // Устанавливаем цену из словаря или по умолчанию
            if (prices.ContainsKey(model))
            {
                sale.Price = prices[model];
            }
            else
            {
                sale.Price = 500.00; // цена по умолчанию
            }

            sale.TotalAmount = sale.Quantity * sale.Price;
            sales.Add(sale);
        }
        static public double CalculateTotalSales(List<PhoneSale> sales, DateTime startDate, DateTime endDate) // Функция для расчета общей суммы продаж
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
        static public string FindBestSellingPhone(List<string> models, List<int> quantities)  // Функция для поиска самого продаваемого телефона
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
        
    }
}
