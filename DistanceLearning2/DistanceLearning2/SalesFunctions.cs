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

    }
}
