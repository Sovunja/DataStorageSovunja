using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorageSovunja
{
    public class Car: Text
    {
        private string _brand;
        private int _year;
        public Car(string brand, int year)
        {
            _brand = brand;
            _year = year;
        }
        public override string Add()
        {
            return($"{base.Add()} [Car] {_brand}, {_year} ");
        }
    }
}
