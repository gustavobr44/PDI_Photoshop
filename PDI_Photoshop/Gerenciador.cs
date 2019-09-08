using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string obtEsteganografia()
        {
            throw new NotImplementedException();
        }

        public Image aplEsteganografia(string texto)
        {
            throw new NotImplementedException();
        }

        public void mostHistograma()
        {
            FormHistograma fHist = new FormHistograma();
            fHist.Activate();
            fHist.Show();

            fHist.atualizarHistograma(funcs.obterHistograma(getImagem()));
        }

        public Image aplEqualizacao()
        {
            throw new NotImplementedException();
        }

        public Image aplFiltroGenerico()
        {
            throw new NotImplementedException();
        }

        public Image aplFiltroMedia()
        {
            throw new NotImplementedException();
        }

        public Image aplFiltroGaussiano()
        {
            throw new NotImplementedException();
        }

        public Image aplLaplaciano()
        {
            throw new NotImplementedException();
        }

        public Image aplHighBoost()
        {
            throw new NotImplementedException();
        }

        public Image aplMediana()
        {
            throw new NotImplementedException();
        }
    }
}
