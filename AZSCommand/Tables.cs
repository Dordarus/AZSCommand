using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZSCommand
{
    internal class NutshellContext : FuelStationControlDataContext
    {
        public Table<Cars> Car => GetTable<Cars>();
        public Table<Fuel> Fuel => GetTable<Fuel>();
        public Table<FuelStations> Fs => GetTable<FuelStations>();
        public Table<Models> Model => GetTable<Models>();
        public Table<Restock> Restock => GetTable<Restock>();
    }
}
