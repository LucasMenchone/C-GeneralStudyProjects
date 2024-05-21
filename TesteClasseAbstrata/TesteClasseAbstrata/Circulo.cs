using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasseAbstrata
{
    internal class Circulo : Forma
    {
        public Circulo(double valor_raio) { 
            Raio = valor_raio;
        }
        public double Raio { get; set; }

        public override void CalculaArea()
        {
            //A = π r²
            Area = Math.PI * Math.Pow(Raio,2);
        }

        public override void CalculaPerimetro()
        {
            //C = 2 * π * r
            Perimetro = 2  * Math.PI * Raio;
        }
    }
}
