using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmHasil : Form
    {

        public FrmHasil()
        {
            InitializeComponent();
        }

        private void FrmEntry_Perhitungan(int A, int B, int index)
        {
            int hasil;

            if (index == 0)
            {
                hasil = A + B;
                lstHasil.Items.Add(string.Format("Hasil Penjumlahan {0} + {1} = {2}", A, B, hasil));
            }
            else if (index == 1)
            {
                hasil = A - B;
                lstHasil.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2}", A, B, hasil));
            }
            else if (index == 2)
            {
                hasil = A * B;
                lstHasil.Items.Add(string.Format("Hasil Perkalian {0} * {1} = {2}", A, B, hasil));
            }
            else if (index == 3)
            {
                hasil = A / B;
                lstHasil.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2}", A, B, hasil));
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmInput frm = new FrmInput();
            frm.Perhitungan += FrmEntry_Perhitungan;

            frm.ShowDialog();
            //Created by adit ehehehe
        }
    }
}
