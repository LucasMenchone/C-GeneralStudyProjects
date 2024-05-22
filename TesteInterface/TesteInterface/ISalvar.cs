using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    internal interface ISalvar
    {
        void Salvar();

        string Compactar()
        {
            return "Arquivo Compactado!";
        }
    }
}
