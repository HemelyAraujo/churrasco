int QueridosAlcoolatras, QueridosCrentes, MiniQueridos, GrandesQueridos, Queridos;
double carne, acompanhamentos, cerveja, refrigerante, agua;

Console.WriteLine("---Churrascada Com Os Queridos---\n");

Console.Write("Queridos Alcoolatras:");
QueridosAlcoolatras = Convert.ToInt32(Console.ReadLine());

Console.Write("Queridos Crentes:");
QueridosCrentes= Convert.ToInt32(Console.ReadLine());

Console.Write("Mini Queridos:");
MiniQueridos = Convert.ToInt32(Console.ReadLine());

GrandesQueridos = QueridosAlcoolatras + QueridosCrentes;
Queridos = GrandesQueridos+ MiniQueridos;

carne = 0.6 * GrandesQueridos + 0.1 * MiniQueridos;
acompanhamentos = 0.3 * Queridos;
cerveja = 5 * QueridosAlcoolatras;
refrigerante = 0.8 * (QueridosCrentes + MiniQueridos);
agua = 0.5 * Queridos;

Console.WriteLine($"Carne.............: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}l");
Console.WriteLine($"Água..............: {agua:N1}l");