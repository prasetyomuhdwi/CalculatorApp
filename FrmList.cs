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
    public partial class FrmList : Form
    {

        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmEntry_Perhitungan(int nilaiA, int nilaiB, int index)
        {
            int hasil;

            if (index == 0)
            {
                hasil = nilaiA + nilaiB;
                lstHasil.Items.Add(string.Format("Hasil penjumlahan {0} + {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 1)
            {
                hasil = nilaiA - nilaiB;
                lstHasil.Items.Add(string.Format("Hasil pengurangan {0} - {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 2)
            {
                hasil = nilaiA * nilaiB;
                lstHasil.Items.Add(string.Format("Hasil perkalian {0} * {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 3)
            {
                hasil = nilaiA / nilaiB;
                lstHasil.Items.Add(string.Format("Hasil pembagian {0} / {1} = {2}", nilaiA, nilaiB, hasil));
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmEntry frm = new FrmEntry();
            frm.Perhitungan += FrmEntry_Perhitungan;

            frm.ShowDialog();
        }
    }
}
