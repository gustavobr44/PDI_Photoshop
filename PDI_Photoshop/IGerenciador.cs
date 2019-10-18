using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PDI_Photoshop
{
    public interface IGerenciador
    {
        void adcImagem(Image imagem);
        Image getImagem();
        void desfazer();
        void refazer();
        void aplNegativo();
        void aplLogaritmo();
        void aplPotencia();
        void aplLinear();
        void mostEsteganografia();
        void aplEsteganografia(String[] texto);
        void mostHistograma();
        void aplEqualizacao();
        void mostFiltro();
        void aplFiltroGenerico(double[,] matriz);
        void aplFiltroMedia();
        void aplFiltroGaussiano();
        void aplLaplaciano();
        void aplHighBoost(double[,] matriz, double k);
        void aplMediana();
    }
}
