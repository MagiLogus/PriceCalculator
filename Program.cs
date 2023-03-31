//As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

// Algoritimo 
// Entrada: Maças compradas 
// Proscessamento: quantidade < 12 = 0.30 * quant / quantidade > 12 = 0.25 * quant 

//Entrada 

Console.WriteLine(@$"
--------------------------------
|        Programa para         |
|   calcular preço de compra   |
|                              |
--------------------------------
");

Console.WriteLine($"Informe a quantidade de maças compradas:");
int maçasCompradas = int.Parse(Console.ReadLine());

// Processamento 
float preçoUnit;

if (maçasCompradas<12)
{
preçoUnit = 0.30f; 
}
else
{
preçoUnit = 0.25f;
}

float valorTotal = maçasCompradas * preçoUnit ;

// Saida

Console.WriteLine($"O valor total da compra é de: R$ {valorTotal}");

