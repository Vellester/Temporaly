using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Shev
{
    public partial class Lab1_Shev : Form
    {
        public Lab1_Shev()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBa.Focus();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            float a, b; double result;           //Переменные для обработки выражения
            a = float.Parse(TBa.Text);
            b = float.Parse(TBa.Text);
            result = (a*a) - b - 7;
            PnRes.Visible = true;
            TbRes.Text = result.ToString();
           
        }

        private void BtnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
