using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI_Photoshop.Interfaces
{
    public partial class FormEsteganografia : Form
    {
        public IGerenciador gere;

        public FormEsteganografia(IGerenciador gere)
        {
            InitializeComponent();
            this.gere = gere;
        }

        public void atualizarEsteganografia(string[] texto)
        {
            txtEstegR.Text = texto[0];
            txtEstegG.Text = texto[1];
            txtEstegB.Text = texto[2];
        }

        private void AplEsteq_Click(object sender, EventArgs e)
        {
            string[] texto = new string[3];

            texto[0] = txtEstegR.Text;
            texto[1] = txtEstegG.Text;
            texto[2] = txtEstegB.Text;

            gere.aplEsteganografia(texto);
            MessageBox.Show("Esteganografia aplicada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.Dispose();
        }
    }
}
