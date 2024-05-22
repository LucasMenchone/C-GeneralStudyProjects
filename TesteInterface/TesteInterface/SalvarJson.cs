using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    
    internal class SalvarJson : ArquivoBase, ISalvar
    {
        public SalvarJson() { }
        public SalvarJson(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
        }
        public string NomeArquivo { get; set; } = string.Empty;
        public override void Nome()
        {
            Console.WriteLine($"Definir um nome JSON");
        }

        public void Salvar()
        {
            Console.WriteLine($"Salvo como {NomeArquivo}.JSON");
        }
    }
}
