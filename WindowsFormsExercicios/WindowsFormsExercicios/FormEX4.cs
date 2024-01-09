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

            timer1.Interval = 1000;
            timer1.Enabled = true;

        }
        
        private void verHoras()
        {
            DateTime horaAtual = DateTime.Now;
            label1.Text = horaAtual.ToString("HH:mm:ss");

            TimeZoneInfo fuso = TimeZoneInfo.Local;
            label2.Text = fuso.ToString();

            label10.Text = horaAtual.ToString();

            DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;

            lblBaker.Text = "       Baker \n       " + dateTimeOffset.AddHours(-12).ToString("HH:mm:ss");
            lblMiller.Text = "       Millersville " + dateTimeOffset.AddHours(-11).ToString("HH:mm:ss");
            lblPaopao.Text = "       Paopao " + dateTimeOffset.AddHours(-10).ToString("HH:mm:ss");
            lblAnchorage.Text = "       Anchorage " + dateTimeOffset.AddHours(-9).ToString("HH:mm:ss");
            lblLosAngeles.Text = "       Los Angeles" + dateTimeOffset.AddHours(-8).ToString("HH:mm:ss");
            lblDawson.Text = "       Dawson " + dateTimeOffset.AddHours(-7).ToString("HH:mm:ss");
            lblMexico.Text = "       Cidade do Mexico " + dateTimeOffset.AddHours(-6).ToString("HH:mm:ss");
            lblLima.Text = "       Lima " + dateTimeOffset.AddHours(-5).ToString("HH:mm:ss");
            lblManaus.Text = "       Manaus " + dateTimeOffset.AddHours(-4).ToString("HH:mm:ss");
            lblSaoPaulo.Text = "       São Paulo " + dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblNuuk.Text = "       Nuuk " + dateTimeOffset.AddHours(-2).ToString("HH:mm:ss");
            lblItto.Text = "       Ittoqqortoormiit " + dateTimeOffset.AddHours(-1).ToString("HH:mm:ss");
            lblAcra.Text = "       Acra " + dateTimeOffset.AddHours(0).ToString("HH:mm:ss");
            lblParis.Text = "       Paris " + dateTimeOffset.AddHours(1).ToString("HH:mm:ss");
            lblCabo.Text = "       Cabo " + dateTimeOffset.AddHours(2).ToString("HH:mm:ss");
            lblIstambul.Text = "       Istambul " + dateTimeOffset.AddHours(3).ToString("HH:mm:ss");
            lblMascate.Text = "       Mascate " + dateTimeOffset.AddHours(4).ToString("HH:mm:ss");
            lblMale.Text = "       Male " + dateTimeOffset.AddHours(5).ToString("HH:mm:ss");
            lblAstana.Text = "       Astana " + dateTimeOffset.AddHours(6).ToString("HH:mm:ss");
            lblBangkok.Text = "       Bangkok " + dateTimeOffset.AddHours(7).ToString("HH:mm:ss");
            lblTaipe.Text = "       Taipe " + dateTimeOffset.AddHours(8).ToString("HH:mm:ss");
            lblTokyo.Text = "       Tokyo " + dateTimeOffset.AddHours(9).ToString("HH:mm:ss");
            lblSydney.Text = "       Sydney " + dateTimeOffset.AddHours(10).ToString("HH:mm:ss");
            lblMagadan.Text = "       Magadan " + dateTimeOffset.AddHours(11).ToString("HH:mm:ss");
            lblSuva.Text = "       Suva \n       " + dateTimeOffset.AddHours(12).ToString("HH:mm:ss");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            verHoras();

        }

    }
}
