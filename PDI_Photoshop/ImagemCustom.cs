using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PDI_Photoshop
{
    class ImagemCustom
    {
        public ImagemCustom imagemAnt;
        public Image imagem;
        public ImagemCustom imagemDep;

        public ImagemCustom(Image imagem)
        {
            this.imagemAnt = null;
            this.imagem = imagem;
            this.imagemDep = null;
        }
    }
}
