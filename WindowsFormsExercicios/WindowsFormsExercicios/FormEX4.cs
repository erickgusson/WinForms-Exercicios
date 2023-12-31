using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercicios
{
    public partial class FormEX4 : Form
    {
        public FormEX4()
        {
            InitializeComponent();
        }

        private void FormEX4_Load(object sender, EventArgs e)
        {
            DateTime horaAtual = DateTime.Now;
            label1.Text = horaAtual.ToString("HH:mm:ss");

            TimeZoneInfo fuso = TimeZoneInfo.Local;
            label2.Text = fuso.ToString();

            

        }
    }
}
