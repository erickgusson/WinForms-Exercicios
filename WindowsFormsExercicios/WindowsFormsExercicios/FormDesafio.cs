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
    public partial class FormDesafio : Form
    {
        public FormDesafio()
        {
            InitializeComponent();
        }

        private void txbTexto_TextChanged(object sender, EventArgs e)
        {

            QRCoder.QRCodeGenerator geradorQR = new QRCoder.QRCodeGenerator();
            var texto = geradorQR.CreateQrCode(txbTexto.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var codigo = new QRCoder.QRCode(texto);
            pbxQR.Image = codigo.GetGraphic(50);

        }
    }
}
