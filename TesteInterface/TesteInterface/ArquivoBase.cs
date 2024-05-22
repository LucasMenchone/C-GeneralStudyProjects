using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("definir o nome do arquivo");
        }
    }
}
