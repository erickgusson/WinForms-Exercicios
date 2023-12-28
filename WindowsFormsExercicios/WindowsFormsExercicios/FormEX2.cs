using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercicios
{
    public partial class FormEX2 : Form
    {
        public FormEX2()
        {
            InitializeComponent();
        }

        private async void cbxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cidade = cbxCidades.SelectedItem.ToString();

            API_EX2_1 apiClima = new API_EX2_1();

            API2_EX2_2 climaInfo = await apiClima.intregacao(cidade);

            cidadeNome.Text = cidadeNome.Text = climaInfo.name;
            temperatura.Text = "" + climaInfo.temp + "º";
            sensacao.Text = "" + climaInfo.feels_like + "º";
            minima.Text = "" + climaInfo.temp_min + "º";
            maxima.Text = "" + climaInfo.temp_max + "º";

        }


    }
}
