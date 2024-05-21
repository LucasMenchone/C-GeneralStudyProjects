using TesteClasseAbstrata;

Quadrado quadrado = new();
Circulo circulo = new(5);

quadrado.Cor = "azul";
quadrado.CalculaPerimetro();
quadrado.CalculaArea();

circulo.Cor = "verde";
circulo.CalculaPerimetro();
circulo.CalculaArea();



Console.WriteLine($"Sou um Quadrado e {quadrado.Descricao()}" +
                $"\nMinha cor é {quadrado.Cor}" +
                $"\nTenho {quadrado.Lado} Lados" +
                $"\nMinha area é {quadrado.Area}m²" +
                $"\nMeu perímetro é {quadrado.Perimetro}m");

Console.WriteLine();

Console.WriteLine($"Sou um Circulo e {circulo.Descricao()}" +
                $"\nMinha cor é {circulo.Cor}" +
                $"\nTenho {circulo.Raio}m de Raio" +
                $"\nMinha area é {circulo.Area.ToString("F")}m²" +
                $"\nMeu perímetro é {circulo.Perimetro.ToString("F")}m");