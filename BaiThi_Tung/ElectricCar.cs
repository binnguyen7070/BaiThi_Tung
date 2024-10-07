using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi_Tung
{
    internal class ElectricCar : Car

    {
        private int batteryCapacity;

        public int BatteryCapacity { get => batteryCapacity; set => batteryCapacity = value; }

        public ElectricCar(string hangXe, string bienSo, int namSanXuat, double giaBan, int batteryCapacity)
            : base(hangXe, bienSo, namSanXuat, giaBan)
        {
            this.batteryCapacity = batteryCapacity;
        }






    


    }
}
