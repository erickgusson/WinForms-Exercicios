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
using Newtonsoft.Json;
using System.Net;

namespace WindowsFormsExercicios
{
    public partial class FormEX2 : Form
    {
        public FormEX2()
        {
            InitializeComponent();
        }

        string chaveAPI = "d0c4d691e3f1fa2da4267474044805d3";

        private async void cbxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string cidade = cbxCidades.SelectedItem.ToString();

            //API_EX2_1 apiClima = new API_EX2_1();

            //API2_EX2_2 climaInfo = await apiClima.intregacao(cidade);

            //cidadeNome.Text = cidadeNome.Text = climaInfo.name;
            //temperatura.Text = "" + climaInfo.temp + "º";
            //sensacao.Text = "" + climaInfo.feels_like + "º";
            //minima.Text = "" + climaInfo.temp_min + "º";
            //maxima.Text = "" + climaInfo.temp_max + "º";

            getWeather();
        }

        void getWeather()
        {
            


            using (WebClient web = new WebClient()) 
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&lang=pt_br&units=metric&appid={1}", cidadeSelecionada, chaveAPI);

                var json = web.DownloadString(url);

                ClimaInfo.root info = JsonConvert.DeserializeObject<ClimaInfo.root>(json);

                temperatura.Text = info.main.temp.ToString();
                sensacao.Text = info.main.feels_like.ToString();
                minima.Text = info.main.temp_min.ToString();
                maxima.Text = info.main.temp_max.ToString();

            }

        }
    }
}
