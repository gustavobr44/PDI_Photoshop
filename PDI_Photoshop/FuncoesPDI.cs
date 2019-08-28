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
    }
}
