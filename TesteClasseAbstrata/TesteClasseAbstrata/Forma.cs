using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasseAbstrata
{
    abstract class Forma
    {
        public string? Cor  { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public abstract void CalculaPerimetro();
        public abstract void CalculaArea();

        public string Descricao()
        {
            return "Sou Parte da Classe Abstrata Forma";
        }
    }
}
