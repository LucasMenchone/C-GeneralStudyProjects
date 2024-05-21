using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasseAbstrata
{
    internal class Quadrado : Forma
    {

        public double Lado { get; set; } = 4;
        public override void CalculaArea()
        {
            Area = Lado * Lado;
        }

        public override void CalculaPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}
