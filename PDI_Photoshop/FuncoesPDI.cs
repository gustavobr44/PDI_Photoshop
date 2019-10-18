using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace PDI_Photoshop
{
    class FuncoesPDI
    {
        public FuncoesPDI()
        {

        }

        public Image aplicarNegativo(Image imagem)
        {
            Bitmap bImagem = (Bitmap)imagem.Clone();

            for (int i = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);
                    pixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    bImagem.SetPixel(i, j, pixel);
                }
            }

            return (Image)bImagem;
        }

        public Image aplicarLog(Image imagem)
        {
            Bitmap bImagem = (Bitmap)imagem.Clone();
            double maxLog = Math.Log(255.0);

            for (int i = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    double R = 255.0 * (Math.Log(pixel.R) / maxLog);
                    double G = 255.0 * (Math.Log(pixel.G) / maxLog);
                    double B = 255.0 * (Math.Log(pixel.B) / maxLog);

                    pixel = Color.FromArgb((byte)R, (byte)G, (byte)B);
                    bImagem.SetPixel(i, j, pixel);
                }
            }

            return (Image)bImagem;
        }

        public Image aplicarPot(Image imagem)
        {
            Bitmap bImagem = (Bitmap)imagem.Clone();
            double maxPot = Math.Pow(255.0, 5);

            for (int i = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    double R = 255.0 * (Math.Pow(pixel.R, 5) / maxPot);
                    double G = 255.0 * (Math.Pow(pixel.G, 5) / maxPot);
                    double B = 255.0 * (Math.Pow(pixel.B, 5) / maxPot);

                    pixel = Color.FromArgb((byte)R, (byte)G, (byte)B);
                    bImagem.SetPixel(i, j, pixel);
                }
            }

            return (Image)bImagem;
        }

        public int[,] obterHistograma(Image imagem)
        {
            Bitmap bImagem = (Bitmap)imagem;
            int[,] hist = new int[256, 3];

            for (int i = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    hist[pixel.R, 0]++;
                    hist[pixel.G, 1]++;
                    hist[pixel.B, 2]++;
                }
            }

            return hist;
        }

        public int[] obterHistogramaH(HSICustom hsi)
        {
            int[] hist = new int[361];

            for (int i = 0; i < hsi.x; i++)
            {
                for (int j = 0; j < hsi.y; j++)
                {
                    hist[(int)(hsi.hsi[i, j, 2]*360)]++;
                }
            }

            return hist;
        }

        public Image aplicarEqua(Image imagem)
        {
            int[,] hist = obterHistograma(imagem);
            Bitmap bImagem = (Bitmap)imagem.Clone();

            int altura = bImagem.Height;
            int largura = bImagem.Width;
            long N = altura * largura;

            int[,] prob = new int[256, 3];

            for (int i = 0; i < 256; i++)
            {
                long sR = 0, sG = 0, sB = 0;

                for (int j = 0; j < i+1; j++)
                {
                    sR += hist[j, 0];
                    sG += hist[j, 1];
                    sB += hist[j, 2];
                }

                prob[i, 0] = (int)(sR * (255.0 / N));
                prob[i, 1] = (int)(sG * (255.0 / N));
                prob[i, 2] = (int)(sB * (255.0 / N));
            }

            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    double R = prob[pixel.R, 0];
                    double G = prob[pixel.G, 1];
                    double B = prob[pixel.B, 2];

                    pixel = Color.FromArgb((byte)R, (byte)G, (byte)B);
                    bImagem.SetPixel(i, j, pixel);
                }
            }

            return (Image)bImagem;
        }

        public Image aplicarEquaH(Image imagem)
        {
            HSICustom hsi = new HSICustom(imagem);
            int[] hist = obterHistogramaH(hsi);

            int altura = imagem.Height;
            int largura = imagem.Width;
            long N = altura * largura;

            double[] prob = new double[361];

            for (int i = 0; i < 361; i++)
            {
                long sI = 0;

                for (int j = 0; j < i + 1; j++)
                {
                    sI += hist[j];
                }

                prob[i] = sI * (360.0 / N);
            }

            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    double I = hsi.hsi[i, j, 2] * 360;

                    double nI = prob[(int)I];

                    hsi.hsi[i, j, 2] = nI / 360;
                }
            }

            return hsi.hsiToRgb();
        }

        public String[] obterEsteganografia(Image imagem)
        {
            String[] esteg = new String[3];
            Bitmap bImagem = (Bitmap)imagem;
            short count = 0;
            int letraR = 0, letraG = 0, letraB = 0;
            
            for (int i = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    letraR |= ((pixel.R & 1) << (count));
                    letraG |= ((pixel.G & 1) << (count));
                    letraB |= ((pixel.B & 1) << (count));

                    if (++count == 8)
                    {
                        count = 0;

                        esteg[0] += (char)letraR;
                        esteg[1] += (char)letraG;
                        esteg[2] += (char)letraB;

                        letraR = 0; letraG = 0; letraB = 0;
                    }
                }
            }

            return esteg;
        }

        public Image aplicarEsteganografia(Image imagem, String[] text)
        {
            Bitmap bImagem = (Bitmap)imagem.Clone();
            int count = 0;
            int[] letra = new int[3];
            int[] cores = new int[3];

            for (int i = 0, indice = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);
                    cores[0] = pixel.R;
                    cores[1] = pixel.G;
                    cores[2] = pixel.B;

                    for (int cor = 0; cor < 3; cor++)
                    {
                        if (indice < text[cor].Length)
                        {
                            if (count == 0)
                            {
                                letra[cor] = text[cor][indice];
                            }

                            cores[cor] = ((letra[cor] & 1) == 1) ? cores[cor] | 1 : cores[cor] & ~1;
                            letra[cor] >>= 1; 
                        }
                    }

                    pixel = Color.FromArgb((byte)cores[0], (byte)cores[1], (byte)cores[2]);
                    bImagem.SetPixel(i, j, pixel);

                    if (++count == 8)
                    {
                        count = 0;
                        indice++;
                    }
                }
            }

            return (Image)bImagem;
        }

        public Image aplicarFiltro(Image imagem, double[,] transf, int t = 0)
        {
            Bitmap bImagem = (Bitmap)imagem;
            int comp = bImagem.Width, altu = bImagem.Height;

            double[,,] dImagem = new double[comp, altu, 3];

            double[,] transfR = rotacionarMatriz(transf);
            int dimTransfR = (int)Math.Sqrt(transfR.Length);
            int cenTransfR = dimTransfR / 2;

            for (int i = 0; i < comp; i++)
            {
                for (int j = 0; j < altu; j++)
                {
                    double sumR = 0, sumG = 0, sumB = 0;

                    for (int a = -cenTransfR; a <= cenTransfR; a++)
                    {
                        for (int b = -cenTransfR; b <= cenTransfR; b++)
                        {
                            if (!(i + a < 0 || j + b < 0 || i + a >= comp || j + b >= altu))
                            {
                                Color pixel = bImagem.GetPixel(i + a, j + b);

                                sumR += pixel.R * transfR[a + cenTransfR, b + cenTransfR];
                                sumG += pixel.G * transfR[a + cenTransfR, b + cenTransfR];
                                sumB += pixel.B * transfR[a + cenTransfR, b + cenTransfR];
                            }
                        }
                    }

                    dImagem[i, j, 0] = sumR; dImagem[i, j, 1] = sumG; dImagem[i, j, 2] = sumB;
                }
            }

            int[,,] iImagem = normalizar(dImagem, comp, altu);

            return intToBitmap(iImagem, comp, altu);
        }

        private double[,] rotacionarMatriz(double[,] matriz)
        {
            int dim = (int)Math.Sqrt(matriz.Length);
            double[,] matrizR = new double[dim, dim];

            for (int i = 0, a = dim-1; i < dim; i++, a--)
            {
                for (int j = 0, b = dim-1; j < dim; j++, b--)
                {
                    matrizR[i, j] = matriz[a, b];
                }
            }

            return matrizR;
        }

        private int[,,] normalizar(double[,,] imagem, int x, int y, double mAx = -10000, double mIn = 10000)
        {
            int[,,] imagemN = new int[x, y, 3];

            for (int c = 0; c < 3; c++)
            {
                /*double max = 1020;
                double min = -1020;*/

                double max = mAx;
                double min = mIn;

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        max = (imagem[i, j, c] > max) ? imagem[i, j, c] : max;
                        min = (imagem[i, j, c] < min) ? imagem[i, j, c] : min;
                    }
                }

                max -= min;

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        imagem[i, j, c] = (imagem[i, j, c] - min) / max;
                        imagemN[i, j, c] = (int)(imagem[i, j, c] * 255);
                    }
                }
            }

            return imagemN;
        }

        private double[,,] bitmapToDouble(Bitmap imagem)
        {
            double[,,] imagemF = new double[imagem.Width, imagem.Height, 3];

            for (int i = 0; i < imagem.Width; i++)
            {
                for (int j = 0; j < imagem.Height; j++)
                {
                    Color pixel = imagem.GetPixel(i, j);

                    imagemF[i, j, 0] = pixel.R;
                    imagemF[i, j, 1] = pixel.G;
                    imagemF[i, j, 2] = pixel.B;
                }
            }

            return imagemF;
        }

        private Bitmap intToBitmap(int[,,] imagem, int x, int y)
        {
            Bitmap imagemB = new Bitmap(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color pixel = Color.FromArgb(imagem[i, j, 0], imagem[i, j, 1], imagem[i, j, 2]);
                    imagemB.SetPixel(i, j, pixel);
                }
            }

            return imagemB;
        }
    }
}
