using BaiThi_Tung;

namespace BaiThi_Tung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        List<Car> ls_cars = new List<Car>();
        private void btn_them_Click(object sender, EventArgs e)
        {
            Car car = new Car(txt_Hxe.Text, txt_Bso.Text, int.Parse(txt_Nsanxuat.Text), double.Parse(txt_Gban.Text));
            ls_cars.Add(car);
            dtv_1.DataSource = null;
            dtv_1.DataSource = ls_cars;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            foreach (Car i in ls_cars)
            {
                if (txt_Hxe.Text == i.Hangxe)
                {
                    i.Namsanxuat = txt_Nsanxuat.Text;
                    i.Giaban = Int32.Parse(txt_Gban.Text);
                    i.Bienso = txt_Bso.Text;

                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                foreach (Car i in ls_cars)
                {
                    if (i.Hangxe == txt_Hxe.Text)
                    {
                        ls_cars.Remove(i);
                    }
                    break;
                }
                dtv_1.DataSource = null;
                dtv_1.DataSource = ls_cars;
            }
        }
        List<ElectricCar> ls_ECar = new List<ElectricCar>();
        private void btn_them1_Click(object sender, EventArgs e)
        {
            ElectricCar ECar = new ElectricCar(txt_Hxe1.Text, txt_Bso1.Text, int.Parse(txt_Nsanxuat1.Text), Int32.Parse(txt_Gban1.Text), Int32.Parse(txt_Dluongpin1.Text));
            ls_ECar.Add(ECar);
            dtv_2.DataSource = null;
            dtv_2.DataSource = ls_ECar;
        }

        private void btn_sua1_Click(object sender, EventArgs e)
        {

            foreach (ElectricCar i in ls_ECar)
            {
                if (txt_Hxe1.Text == i.Hangxe)
                {
                    i.Namsanxuat = txt_Nsanxuat1.Text;
                    i.Giaban = Int32.Parse(txt_Gban1.Text);
                    i.Bienso = txt_Bso1.Text;
                    i.BatteryCapacity = Int32.Parse(txt_Dluongpin1.Text);
                }
            }
        }

        private void btn_xoa1_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in ls_ECar)
            {
                if (i.Hangxe == txt_Hxe1.Text)
                {
                    ls_ECar.Remove(i);
                }
                break;
            }
            dtv_2.DataSource = null;
            dtv_2.DataSource = ls_ECar;
        }
    }
}