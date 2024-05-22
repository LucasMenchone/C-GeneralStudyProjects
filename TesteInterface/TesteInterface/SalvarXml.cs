using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    internal class SalvarXml : ArquivoBase, ISalvar
    {
        public SalvarXml() { }
        public SalvarXml(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
        }
        public string NomeArquivo { get; set; } = string.Empty;
        public override void Nome()
        {
            Console.WriteLine($"Definir um nome XML");
        }

        public void Salvar()
        {
            Console.WriteLine($"Salvo como {NomeArquivo}.XML");
        }
    }
}
