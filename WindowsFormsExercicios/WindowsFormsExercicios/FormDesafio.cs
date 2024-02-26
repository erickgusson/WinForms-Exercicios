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

            lblContador.Text = txbTexto.TextLength.ToString();

            QRCoder.QRCodeGenerator geradorQR = new QRCoder.QRCodeGenerator();
            var texto = geradorQR.CreateQrCode(txbTexto.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var codigo = new QRCoder.QRCode(texto);
            pbxQR.Image = codigo.GetGraphic(50);

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            Bitmap salvarImagem = BaixarQRCode(pbxQR);

            if (salvarImagem != null)
            {

                SaveFileDialog selecionarOndeBaixar = new SaveFileDialog();
                selecionarOndeBaixar.Filter = "Arquivos de Imagem|*.png";
                selecionarOndeBaixar.Title = "Salvar Imagem";
                selecionarOndeBaixar.FileName = "QR Code " + txbTexto.Text;

                if (selecionarOndeBaixar.ShowDialog() == DialogResult.OK)
                {

                    string filePath = selecionarOndeBaixar.FileName;

                    try
                    {

                        salvarImagem.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Imagem salva com sucesso!");

                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Erro ao salvar a imagem: " + erro.Message);
                    }

                }
            }
        }

        private Bitmap BaixarQRCode(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {

                Bitmap salvarImagem = new Bitmap(pictureBox.Width, pictureBox.Height);

                using (Graphics imagem = Graphics.FromImage(salvarImagem))
                {

                    imagem.DrawImage(pictureBox.Image, 0, 0, pictureBox.Width, pictureBox.Height);

                }

                return salvarImagem;

            }

            return null;

        }


    }
}
