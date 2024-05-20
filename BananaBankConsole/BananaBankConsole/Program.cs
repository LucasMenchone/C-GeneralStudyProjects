using BananaBankConsole;

Cliente a = new ("Lucas",200m); //nome e saldo inicial
Cliente b = new("Tiago", 5000.75m);

a.ExibeDados();
Console.WriteLine();
b.ExibeDados();

Console.WriteLine("\n-------------------------\n");

a.Transferencia(b, 300m);

a.ExibeDados();
Console.WriteLine();
b.ExibeDados();

