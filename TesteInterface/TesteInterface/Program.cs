using TesteInterface;

string? input;

ISalvar salvarInterface = new SalvarJson();
SalvarJson json = new SalvarJson();
SalvarXml xml = new SalvarXml();

json.Nome();
input = Console.ReadLine();
json.NomeArquivo = string.IsNullOrEmpty(input) ? "Default" : input;
Console.WriteLine(salvarInterface.Compactar());
json.Salvar();

Console.WriteLine();

xml.Nome();
input = Console.ReadLine();
xml.NomeArquivo = string.IsNullOrEmpty(input) ? "Default" : input;
Console.WriteLine(salvarInterface.Compactar());
xml.Salvar();