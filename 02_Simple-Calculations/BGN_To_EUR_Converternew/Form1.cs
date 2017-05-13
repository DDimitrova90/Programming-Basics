using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGN_To_EUR_Converternew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            var currencyRate = 1.95583M;  // M zashtoto e decimal
            var value = this.numericUpDownAmount.Value;
            var result = value / currencyRate;
            this.labelResult1.Text = result.ToString();
        }
    }
}
