using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PDI_Photoshop
{
    interface IGerenciador
    {
        void adcImagem(Image imagem);
        Image getImagem();
        void desfazer();
        void refazer();
        void aplNegativo();
        void aplLogaritmo();
        void aplPotencia();
        void aplLinear();
        String obtEsteganografia();
        Image aplEsteganografia(String texto);
        void mostHistograma();
        Image aplEqualizacao();
        Image aplFiltroGenerico();
        Image aplFiltroMedia();
        Image aplFiltroGaussiano();
        Image aplLaplaciano();
        Image aplHighBoost();
        Image aplMediana();
    }
}
