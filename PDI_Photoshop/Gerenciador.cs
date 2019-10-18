using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDI_Photoshop.Interfaces;

namespace PDI_Photoshop
{
    class Gerenciador : IGerenciador
    {
        private ImagemCustom imagemC;
        private PictureBox imDisplay;
        private FuncoesPDI funcs;

        public Gerenciador(PictureBox imDisplay)
        {
            imagemC = null;
            this.imDisplay = imDisplay;
            funcs = new FuncoesPDI();
        }

        public void adcImagem(Image imagem)
        {
            if (this.imagemC == null)
            {
                this.imagemC = new ImagemCustom(imagem);
            }
            else
            {
                if (imagemC.imagemDep != null)
                {
                    imagemC.imagemDep.disposeDeps();
                }

                ImagemCustom imagemNov = new ImagemCustom(imagem);
                imagemNov.imagemAnt = this.imagemC;
                this.imagemC.imagemDep = imagemNov;
                this.imagemC = imagemNov;
            }

            imDisplay.Image = getImagem();
        }

        public Image getImagem()
        {
            return imagemC.imagem;
        }

        public void desfazer()
        {
            this.imagemC = this.imagemC.imagemAnt;
            imDisplay.Image = getImagem();
        }

        public void refazer()
        {
            this.imagemC = this.imagemC.imagemDep;
            imDisplay.Image = getImagem();
        }

        public void aplNegativo()
        {
            adcImagem(funcs.aplicarNegativo(getImagem()));
        }

        public void aplLogaritmo()
        {
            adcImagem(funcs.aplicarLog(getImagem()));
        }

        public void aplPotencia()
        {
            adcImagem(funcs.aplicarPot(getImagem()));
        }

        public void aplLinear()
        {
            throw new NotImplementedException();
        }

        public void mostEsteganografia()
        {
            FormEsteganografia fEsteg = new FormEsteganografia(this);
            fEsteg.Activate();
            fEsteg.Show();

            fEsteg.atualizarEsteganografia(funcs.obterEsteganografia(getImagem()));
        }

        public void aplEsteganografia(string[] texto)
        {
            adcImagem(funcs.aplicarEsteganografia(getImagem(), texto));
        }

        public void mostHistograma()
        {
            FormHistograma fHist = new FormHistograma();
            fHist.Activate();
            fHist.Show();

            fHist.atualizarHistograma(funcs.obterHistograma(getImagem()));
        }

        public void aplEqualizacao()
        {
            adcImagem(funcs.aplicarEquaH(getImagem()));
        }

        public void mostFiltro()
        {
            FormFiltro fFilt = new FormFiltro(this);
            fFilt.Activate();
            fFilt.Show();
        }

        public void aplFiltroGenerico(double[,] matriz)
        {
            adcImagem(funcs.aplicarFiltro(getImagem(), matriz));
        }

        public void aplFiltroMedia()
        {
            throw new NotImplementedException();
        }

        public void aplFiltroGaussiano()
        {
            throw new NotImplementedException();
        }

        public void aplLaplaciano()
        {
            throw new NotImplementedException();
        }

        public void aplHighBoost(double[,] matriz, double k)
        {
            throw new NotImplementedException();
        }

        public void aplMediana()
        {
            throw new NotImplementedException();
        }
    }
}
