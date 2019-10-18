using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDI_Photoshop
{
    class HSICustom
    {
        double[,,] hsi;
        int x, y;

        public HSICustom(int x, int y)
        {
            this.x = x;
            this.y = y;
            hsi = new double[x, y, 3];
        }

        public HSICustom(Image imagem)
        {
            this.x = imagem.Width;
            this.y = imagem.Height;
            hsi = rgbToHsi(imagem);
        }

        public double[,,] rgbToHsi(Image imagem)
        {
            Bitmap bImagem = (Bitmap)imagem;
            int x = bImagem.Width, y = bImagem.Height;
            double[,,] hsi = new double[x, y, 3];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    double R = (double)pixel.R / 255;
                    double G = (double)pixel.G / 255;
                    double B = (double)pixel.B / 255;

                    double min = R;
                    min = (G < min) ? G : min;
                    min = (B < min) ? B : min;

                    double teta = Math.Acos(1.0 / 2 * ((R - G) + (R - B)) / Math.Pow(Math.Pow(R - G, 2) + (R - B) * (G - B), 1.0 / 2));
                    teta = teta * 180 / Math.PI;

                    double H = (B <= G) ? teta : 360 - teta;
                    double S = 1 - (3 * min / (R + B + G));
                    double I = (R + G + B) / 3;

                    hsi[i, j, 0] = H / 360; hsi[i, j, 1] = S; hsi[i, j, 2] = I;
                }
            }

            return hsi;
        }

        public Image hsiToRgb()
        {
            Bitmap bImagem = new Bitmap(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    double R, G, B;

                    double H = hsi[i, j, 0] * 360;
                    double S = hsi[i, j, 1];
                    double I = hsi[i, j, 2];

                    if (H < 120)
                    {
                        B = I * (1 - S);
                        R = I * (1 + (S * Math.Cos(H) / Math.Cos(60 - H)));
                        G = 3 * I - (R + B);
                    }
                    else if (H < 240)
                    {
                        H = H - 120;

                        R = I * (1 - S);
                        G = I * (1 + (S * Math.Cos(H) / Math.Cos(60 - H)));
                        B = 3 * I - (R + G);
                    }
                    else
                    {
                        H = H - 240;

                        G = I * (1 - S);
                        B = I * (1 + (S * Math.Cos(H) / Math.Cos(60 - H)));
                        R = 3 * I - (G + B);
                    }

                    Color pixel = Color.FromArgb((int)R * 255, (int)G * 255, (int)B * 255);
                }
            }

            return bImagem;
        }
    }
}
