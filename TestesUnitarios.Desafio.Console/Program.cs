// See https://aka.ms/new-console-template for more information
using TestesUnitarios.Desafio.Console.Services;

Console.WriteLine("Hello, World!");

ValidacoesLista x1 = new ValidacoesLista();
 var valores = new List<int> {5,-5,-9,8};

valores.Add(-7);


valores = x1.RemoverNumerosNegativos(valores);

for (int i = 0; i < valores.Count; i++)
{
    Console.WriteLine(valores[i]);
}
