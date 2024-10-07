using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi_Tung
{
    internal class Car
    {
        string hangxe;
        string bienso;
        string namsanxuat;
        int giaban;

        public string Hangxe { get => hangxe; set => hangxe = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public string Namsanxuat { get => namsanxuat; set => namsanxuat = value; }
        public int Giaban { get => giaban; set => giaban = value; }

        public Car() { }

        public Car(string hangXe, string bienSo, int namSanXuat, double giaBan)
        {
            this.hangxe = hangXe;
            this.bienso = bienSo;
            this.namsanxuat = namsanxuat;
            this.giaban = giaban;


        }
    }
}
