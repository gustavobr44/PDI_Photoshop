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
    public partial class FormFiltro : Form
    {
        IGerenciador gere;
        private NumericUpDown[,] matriz;
        private int dim;

        public FormFiltro(IGerenciador gere)
        {
            InitializeComponent();
            this.gere = gere;

            matriz = new NumericUpDown[9, 9];
            createMatrix();
            dim = 0;
            rdbGenerico.Checked = true;
        }

        private void createMatrix()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matriz[i, j] = new NumericUpDown();
                    flowLayoutPanel1.Controls.Add(matriz[i, j]);

                    matriz[i, j].DecimalPlaces = 4;
                    matriz[i, j].Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    matriz[i, j].Increment = new decimal(new int[] { 1, 0, 0, 65536 });
                    matriz[i, j].Margin = new Padding(5);
                    matriz[i, j].Location = new Point(13, 13);
                    matriz[i, j].Size = new Size(90, 22);
                    matriz[i, j].TextAlign = HorizontalAlignment.Center;
                    matriz[i, j].Minimum = -100M;
                    matriz[i, j].Maximum = 100M;
                    matriz[i, j].Enabled = false;
                }
            }
        }

        private void disableMatrix()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matriz[i, j].Enabled = false;
                }
            }
        }

        private void enableMatrix(double value = 0, double[,] mat = null)
        {
            int meio9 = 9 / 2, meioDim = dim / 2;
            int matDim = dim;

            for (int i = meio9 - meioDim, x = 0; i <= meioDim + meio9; i++, x++)
            {
                for (int j = meio9 - meioDim, y = 0; j <= meioDim + meio9; j++, y++)
                {
                    matriz[i, j].Enabled = true;

                    if (mat == null)
                    {
                        matriz[i, j].Value = (decimal)value;
                    }
                    else
                    {
                        matriz[i, j].Value = (decimal)mat[x, y]/16;
                    }
                }
            }
        }

        private void genericoSelect()
        {
            if (rdb3.Checked)
            {
                dim = 3;
                enableMatrix();
            }
            else if (rdb5.Checked)
            {
                dim = 5;
                enableMatrix();
            }
            else if (rdb7.Checked)
            {
                dim = 7;
                enableMatrix();
            }
            else if (rdb9.Checked)
            {
                dim = 9;
                enableMatrix();
            }
        }

        private void mediaSelect()
        {
            if (rdb3.Checked)
            {
                dim = 3;
                double media = 1.0 / Math.Pow(dim, 2);
                enableMatrix(media);
            }
            else if (rdb5.Checked)
            {
                dim = 5;
                double media = 1.0 / Math.Pow(dim, 2);
                enableMatrix(media);
            }
            else if (rdb7.Checked)
            {
                dim = 7;
                double media = 1.0 / Math.Pow(dim, 2);
                enableMatrix(media);
            }
            else if (rdb9.Checked)
            {
                dim = 9;
                double media = 1.0 / Math.Pow(dim, 2);
                enableMatrix(media);
            }
        }

        private void gaussianoSelect()
        {
            dim = 3;
            double[,] matGaussiano = { { 1, 2, 1 }, { 2, 4, 2 }, { 1, 2, 1 } };
            enableMatrix(16, matGaussiano);
        }

        private void laplaceSelect()
        {
            dim = 3;
            double[,] matLaplace = { { 1, 1, 1 }, { 1, -8, 1 }, { 1, 1, 1 } };
            enableMatrix(1, matLaplace);
        }

        private void boostSelect()
        {
            dim = 1;
            enableMatrix(1);
        }

        private void Rdb3_CheckedChanged(object sender, EventArgs e)
        {
            disableMatrix();

            if (rdbGenerico.Checked)
            {
                genericoSelect();
            }
            else if (rdbMedia.Checked)
            {
                mediaSelect();
            }
            else if (rdbGaussiano.Checked)
            {
                gaussianoSelect();
            }
            else if (rdbLaplaciano.Checked)
            {
                laplaceSelect();
            }
            else if (rdbHighBoost.Checked)
            {
                boostSelect();
            }
        }

        private void BtnAplFiltro_Click(object sender, EventArgs e)
        {
            if (dim != 0)
            {
                double[,] dMatriz = new double[dim, dim];
                int meio9 = 9 / 2, meioDim = dim / 2;

                for (int i = meio9 - meioDim, a = 0; i <= meioDim + meio9; i++, a++)
                {
                    for (int j = meio9 - meioDim, b = 0; j <= meioDim + meio9; j++, b++)
                    {
                        dMatriz[a, b] = (double)matriz[i, j].Value;
                    }
                }

                if (dim == 1)
                {
                    double k = dMatriz[0, 0];
                    double[,] matBoost = { { -k, -k, -k }, { -k, 8 * k + 1, -k }, { -k, -k, -k } };
                    gere.aplFiltroGenerico(matBoost);
                }
                else
                {
                    gere.aplFiltroGenerico(dMatriz);
                }

                MessageBox.Show("Filtro aplicado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
