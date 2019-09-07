using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI_Photoshop
{
    public partial class FormPrincipal : Form
    {
        private Image imagem;
        private FuncoesPDI func;

        public FormPrincipal()
        {
            InitializeComponent();

            func = new FuncoesPDI();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagem = new OpenFileDialog();
            abrirImagem.Title = "Abrir Imagem";
            abrirImagem.Filter = "JPG Image|*.jpg|BMP Image|*.bmp";

            if (abrirImagem.ShowDialog() == DialogResult.OK)
            {
                imagem = Image.FromFile(abrirImagem.FileName);
                imgDisplay.Image = imagem;
                abrirImagem.Dispose();
            }
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarImagem = new SaveFileDialog();
            salvarImagem.Title = "Salvar Imagem";
            salvarImagem.Filter = "JPG Image|*.jpg|BMP Image|*.bmp";

            if (salvarImagem.ShowDialog() == DialogResult.OK)
            {
                imagem.Save(salvarImagem.FileName);
                MessageBox.Show("Imagem salva com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salvarImagem.Dispose();
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void FuncaoNeg_Click(object sender, EventArgs e)
        {
            imagem = func.aplicarNegativo(imagem);

            imgDisplay.Image = imagem;
        }

        private void FuncaoLog_Click(object sender, EventArgs e)
        {
            imagem = func.aplicarLog(imagem);

            imgDisplay.Image = imagem;
        }

        private void HistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistograma fHist = new FormHistograma();
            fHist.Activate();
            fHist.Show();

            fHist.atualizarHistograma(func.obterHistograma(imagem));
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal novaJanela = new FormPrincipal();
            novaJanela.Activate();
            novaJanela.Show();
        }

        private void FuncaoPot_Click(object sender, EventArgs e)
        {
            imagem = func.aplicarPot(imagem);

            imgDisplay.Image = imagem;
        }
    }
}

