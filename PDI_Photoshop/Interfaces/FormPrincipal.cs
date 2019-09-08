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
        private IGerenciador gere;

        public FormPrincipal()
        {
            InitializeComponent();

            gere = new Gerenciador(imgDisplay);
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal novaJanela = new FormPrincipal();
            novaJanela.Activate();
            novaJanela.Show();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagem = new OpenFileDialog();
            abrirImagem.Title = "Abrir Imagem";
            abrirImagem.Filter = "JPG Image|*.jpg|BMP Image|*.bmp";

            if (abrirImagem.ShowDialog() == DialogResult.OK)
            {
                Image imagem = Image.FromFile(abrirImagem.FileName);
                gere.adcImagem(imagem);
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
                Image imagem = gere.getImagem();
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
            gere.aplNegativo();
        }

        private void FuncaoLog_Click(object sender, EventArgs e)
        {
            gere.aplLogaritmo();
        }

        private void FuncaoPot_Click(object sender, EventArgs e)
        {
            gere.aplPotencia();
        }

        private void HistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gere.mostHistograma();
        }

        private void DesfazerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gere.desfazer();
        }

        private void RefazerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gere.refazer();
        }

        private void FuncaoEqu_Click(object sender, EventArgs e)
        {
            gere.aplEqualizacao();
        }
    }
}

