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
    public partial class FormHistograma : Form
    {
        public FormHistograma()
        {
            InitializeComponent();
        }

        public void atualizarHistograma(int[,] hist)
        {
            graficoHistR.Series[0].Points.Clear();
            graficoHistG.Series[0].Points.Clear();
            graficoHistB.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                graficoHistR.Series[0].Points.AddY(hist[i, 0]);
                graficoHistG.Series[0].Points.AddY(hist[i, 1]);
                graficoHistB.Series[0].Points.AddY(hist[i, 2]);
            }
        }
    }
}
