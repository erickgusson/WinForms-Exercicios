using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NodaTime;
using NodaTime.TimeZones;

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

            DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;
            label10.Text = dateTimeOffset.AddHours(1).ToString();

            lblBaker.Text += " \n       " + dateTimeOffset.AddHours(-12).ToString("HH:mm:ss");
            lblMiller.Text += " " + dateTimeOffset.AddHours(-11).ToString("HH:mm:ss");
            lblPaopao.Text += " " + dateTimeOffset.AddHours(-10).ToString("HH:mm:ss");
            lblAnchorage.Text += " " + dateTimeOffset.AddHours(-9).ToString("HH:mm:ss");
            lblLosAngeles.Text += " " + dateTimeOffset.AddHours(-8).ToString("HH:mm:ss");
            lblDawson.Text += " " + dateTimeOffset.AddHours(-7).ToString("HH:mm:ss");
            lblMexico.Text += " " + dateTimeOffset.AddHours(-6).ToString("HH:mm:ss");
            lblLima.Text += " " + dateTimeOffset.AddHours(-5).ToString("HH:mm:ss");
            lblManaus.Text += " " + dateTimeOffset.AddHours(-4).ToString("HH:mm:ss");
            lblSaoPaulo.Text += " " + dateTimeOffset.AddHours(-3).ToString("HH:mm:ss");
            lblNuuk.Text += " " + dateTimeOffset.AddHours(-2).ToString("HH:mm:ss");
            lblItto.Text += " " + dateTimeOffset.AddHours(-1).ToString("HH:mm:ss");
            lblAcra.Text += " " + dateTimeOffset.AddHours(0).ToString("HH:mm:ss");
            lblParis.Text += " " + dateTimeOffset.AddHours(1).ToString("HH:mm:ss");
            lblCabo.Text += " " + dateTimeOffset.AddHours(2).ToString("HH:mm:ss");
            lblIstambul.Text += " " + dateTimeOffset.AddHours(3).ToString("HH:mm:ss");
            lblMascate.Text += " " + dateTimeOffset.AddHours(4).ToString("HH:mm:ss");
            lblMale.Text += " " + dateTimeOffset.AddHours(5).ToString("HH:mm:ss");
            lblAstana.Text += " " + dateTimeOffset.AddHours(6).ToString("HH:mm:ss");
            lblBangkok.Text += " " + dateTimeOffset.AddHours(7).ToString("HH:mm:ss");
            lblTaipe.Text += " " + dateTimeOffset.AddHours(8).ToString("HH:mm:ss");
            lblTokyo.Text += " " + dateTimeOffset.AddHours(9).ToString("HH:mm:ss");
            lblSydney.Text += " " + dateTimeOffset.AddHours(10).ToString("HH:mm:ss");
            lblMagadan.Text += " " + dateTimeOffset.AddHours(11).ToString("HH:mm:ss");
            lblSuva.Text += " \n       " + dateTimeOffset.AddHours(12).ToString("HH:mm:ss");


        }
    }
}
