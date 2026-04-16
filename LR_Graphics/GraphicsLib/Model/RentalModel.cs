using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib.Model
{
    public class RentalModel
    {
        private Dictionary<Item, List<RentalRecord>> _data = new Dictionary<Item, List<RentalRecord>>();

        public void LoadData()
        {
            var bike = new Item { Name = "Велосипед", PricePerDay = 500 };
            var skates = new Item { Name = "Ролики", PricePerDay = 300 };
            var ski = new Item { Name = "Лыжи", PricePerDay = 600 };

            _data.Add(bike, new List<RentalRecord> {
            new RentalRecord { Date = DateTime.Today.AddDays(-2), Quantity = 5 },
            new RentalRecord { Date = DateTime.Today.AddDays(-1), Quantity = 8 },
            new RentalRecord { Date = DateTime.Today, Quantity = 12 }
        });

            _data.Add(skates, new List<RentalRecord> {
            new RentalRecord { Date = DateTime.Today.AddDays(-2), Quantity = 10 },
            new RentalRecord { Date = DateTime.Today.AddDays(-1), Quantity = 7 },
            new RentalRecord { Date = DateTime.Today, Quantity = 4 }
        });

            _data.Add(ski, new List<RentalRecord> {
            new RentalRecord { Date = DateTime.Today.AddDays(-2), Quantity = 2 },
            new RentalRecord { Date = DateTime.Today.AddDays(-1), Quantity = 3 },
            new RentalRecord { Date = DateTime.Today, Quantity = 1 }
        });
        }

        public List<Item> GetItems() => _data.Keys.ToList();

        public List<RentalRecord> GetRecordsForItem(string name) =>
            _data.FirstOrDefault(x => x.Key.Name == name).Value ?? new List<RentalRecord>();

        public double GetRevenueForItem(Item item) =>
            _data[item].Sum(r => r.Quantity * item.PricePerDay);

        public double GetTotalRevenue() =>
            _data.Keys.Sum(item => GetRevenueForItem(item));
    }
}
