using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022430004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            string[] satuansuhu = { "Celcius", "Fahrenheit", "Kelvin", "Reamur" };

            satuanawal.Items.AddRange(satuansuhu);
            satuanakhir.Items.AddRange(satuansuhu);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void satuanawal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void satuanakhir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nilaiawal_TextChanged(object sender, EventArgs e)
        {

        }

        private void nilaiakhir_TextChanged(object sender, EventArgs e)
        {

        }

        private double KonversiSuhu(double nilai, string awal, string akhir)
        {
            double C = 0;
            switch (awal)
            {
                case "Celcius":
                    C = nilai;
                    break;
                case "Fahrenheit":
                    C = (nilai - 32) * 5 / 9;
                    break;
                case "Kelvin":
                    C = nilai - 273.15;
                    break;
                case "Reamur":
                    C = nilai * 5 / 4;
                    break;
            }
            switch (akhir)
            {
                case "Celcius":
                    return C;
                    break;
                case "Fahrenheit":
                    return (C * 9 / 5) + 32;
                    break;
                case "Kelvin":
                    return C + 273.15;
                    break;
                case "Reamur":
                    return C * 5 / 4;
                    break;
                default:
                    return 0;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if(satuanawal.SelectedItem == null || satuanakhir.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }
            if (string.IsNullOrWhiteSpace(nilaiawal.Text))
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }
            if(!double.TryParse(nilaiawal.Text, out double nilaiAwal))
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }
            string satuan1 = satuanawal.SelectedItem.ToString();
            string satuan2 = satuanakhir.SelectedItem.ToString();

            double hasil = KonversiSuhu(nilaiAwal, satuan1, satuan2);

            nilaiakhir.Text = hasil.ToString();
        }
    }
}
