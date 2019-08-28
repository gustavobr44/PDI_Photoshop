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
            Bitmap bImagem = (Bitmap)imagem;

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
            Bitmap bImagem = (Bitmap)imagem;

            for (int i = 0; i < bImagem.Width; i++)
            {
                for (int j = 0; j < bImagem.Height; j++)
                {
                    Color pixel = bImagem.GetPixel(i, j);

                    double R = 255.0 * Math.Log(1.0 + (pixel.R / 255.0), 2);
                    double G = 255.0 * Math.Log(1.0 + (pixel.G / 255.0), 2);
                    double B = 255.0 * Math.Log(1.0 + (pixel.B / 255.0), 2);

                    pixel = Color.FromArgb((int)R, (int)G, (int)B);
                    bImagem.SetPixel(i, j, pixel);
                }
            }

            return (Image)bImagem;
        }
    }
}
