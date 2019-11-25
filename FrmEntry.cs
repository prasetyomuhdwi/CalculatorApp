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
    public partial class FrmEntry : Form
    {
        public delegate void CreateUpdateEventHandler(int nilaiA, int nilaiB, int index);

        public event CreateUpdateEventHandler Perhitungan;

        public FrmEntry()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            Perhitungan(a, b, cbOperasi.SelectedIndex);
        }
    }
}
