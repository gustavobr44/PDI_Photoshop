using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
