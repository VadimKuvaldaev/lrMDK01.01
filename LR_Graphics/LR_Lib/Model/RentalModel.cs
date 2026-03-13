using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.Model
{
    public class RentalModel
    {
        private Dictionary<RentalItem, List<RentalRecord>> rentalsByItem_ =
            new Dictionary<RentalItem, List<RentalRecord>>();

        public void AddRentals(RentalItem item, List<RentalRecord> rentals)
        {
            if (rentalsByItem_.ContainsKey(item))
            {
                rentalsByItem_[item].AddRange(rentals);
            }
            else
            {
                rentalsByItem_.Add(item, rentals);
            }
        }

        public List<RentalRecord> LoadRentalsForItem(string itemName)
        {
            List<RentalItem> allItems = rentalsByItem_.Keys.ToList();
            RentalItem targetItem = allItems.Find(item => item.Name == itemName);
            if (targetItem != null)
            {
                return rentalsByItem_[targetItem];
            }
            return new List<RentalRecord>();
        }

        public bool Load()
        {

            AddRentals(new RentalItem { Name = "Велосипед", PricePerDay = 500 },
                new List<RentalRecord>() {
                    new RentalRecord { Date = new DateTime(2026, 2, 1), Quantity = 5 },
                    new RentalRecord { Date = new DateTime(2026, 2, 2), Quantity = 7 },
                    new RentalRecord { Date = new DateTime(2026, 2, 3), Quantity = 10 },
                    new RentalRecord { Date = new DateTime(2026, 2, 4), Quantity = 8 },
                    new RentalRecord { Date = new DateTime(2026, 2, 5), Quantity = 12 },
                    new RentalRecord { Date = new DateTime(2026, 2, 6), Quantity = 15 },
                    new RentalRecord { Date = new DateTime(2026, 2, 7), Quantity = 9 },
                    new RentalRecord { Date = new DateTime(2026, 2, 8), Quantity = 6 },
                    new RentalRecord { Date = new DateTime(2026, 2, 9), Quantity = 4 },
                    new RentalRecord { Date = new DateTime(2026, 2, 10), Quantity = 3 },
                });


            AddRentals(new RentalItem { Name = "Ролики", PricePerDay = 300 },
                new List<RentalRecord>() {
                    new RentalRecord { Date = new DateTime(2026, 2, 1), Quantity = 8 },
                    new RentalRecord { Date = new DateTime(2026, 2, 2), Quantity = 10 },
                    new RentalRecord { Date = new DateTime(2026, 2, 3), Quantity = 12 },
                    new RentalRecord { Date = new DateTime(2026, 2, 4), Quantity = 9 },
                    new RentalRecord { Date = new DateTime(2026, 2, 5), Quantity = 7 },
                    new RentalRecord { Date = new DateTime(2026, 2, 6), Quantity = 11 },
                    new RentalRecord { Date = new DateTime(2026, 2, 7), Quantity = 14 },
                    new RentalRecord { Date = new DateTime(2026, 2, 8), Quantity = 6 },
                    new RentalRecord { Date = new DateTime(2026, 2, 9), Quantity = 5 },
                    new RentalRecord { Date = new DateTime(2026, 2, 10), Quantity = 4 },
                });

            AddRentals(new RentalItem { Name = "Самокат", PricePerDay = 400 },
                new List<RentalRecord>() {
                    new RentalRecord { Date = new DateTime(2026, 2, 1), Quantity = 6 },
                    new RentalRecord { Date = new DateTime(2026, 2, 2), Quantity = 8 },
                    new RentalRecord { Date = new DateTime(2026, 2, 3), Quantity = 11 },
                    new RentalRecord { Date = new DateTime(2026, 2, 4), Quantity = 13 },
                    new RentalRecord { Date = new DateTime(2026, 2, 5), Quantity = 9 },
                    new RentalRecord { Date = new DateTime(2026, 2, 6), Quantity = 7 },
                    new RentalRecord { Date = new DateTime(2026, 2, 7), Quantity = 10 },
                    new RentalRecord { Date = new DateTime(2026, 2, 8), Quantity = 12 },
                    new RentalRecord { Date = new DateTime(2026, 2, 9), Quantity = 8 },
                    new RentalRecord { Date = new DateTime(2026, 2, 10), Quantity = 5 },
                });


            AddRentals(new RentalItem { Name = "Лыжи", PricePerDay = 600 },
                new List<RentalRecord>() {
                    new RentalRecord { Date = new DateTime(2026, 2, 1), Quantity = 3 },
                    new RentalRecord { Date = new DateTime(2026, 2, 2), Quantity = 4 },
                    new RentalRecord { Date = new DateTime(2026, 2, 3), Quantity = 6 },
                    new RentalRecord { Date = new DateTime(2026, 2, 4), Quantity = 8 },
                    new RentalRecord { Date = new DateTime(2026, 2, 5), Quantity = 10 },
                    new RentalRecord { Date = new DateTime(2026, 2, 6), Quantity = 7 },
                    new RentalRecord { Date = new DateTime(2026, 2, 7), Quantity = 5 },
                    new RentalRecord { Date = new DateTime(2026, 2, 8), Quantity = 4 },
                    new RentalRecord { Date = new DateTime(2026, 2, 9), Quantity = 2 },
                    new RentalRecord { Date = new DateTime(2026, 2, 10), Quantity = 1 },
                });

            return true;
        }

        public List<RentalItem> GetAllItems()
        {
            return rentalsByItem_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<RentalItem, List<RentalRecord>> keyValue in rentalsByItem_)
            {
                RentalItem item = keyValue.Key;
                result += keyValue.Value.Sum(rental => rental.Quantity * item.PricePerDay);
            }
            return result;
        }

        public RentalItem GetItem(string itemName)
        {
            foreach (KeyValuePair<RentalItem, List<RentalRecord>> keyValue in rentalsByItem_)
            {
                RentalItem item = keyValue.Key;
                if (item.Name == itemName)
                {
                    return item;
                }
            }
            return null;
        }

        public double GetProfitByItem(RentalItem item)
        {
            if (rentalsByItem_.ContainsKey(item))
            {
                return rentalsByItem_[item].Sum(rental => rental.Quantity * item.PricePerDay);
            }
            return 0.0;
        }
    }
}
