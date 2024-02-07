// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

void inicio()
{
    Console.Clear();
    Console.Write("\nDigite 1 para digitar o nome do carro ou -1 para sair: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int verificarSaida = int.Parse(opcaoEscolhida);
    if (verificarSaida == -1) {
        Console.WriteLine("Encerrando.");
    }
    else
    {
        Console.Clear();
        Console.Write($"Digite o nome do carro: ");
        string nomeDoCarro = Console.ReadLine()!;
        descobrirMedia(nomeDoCarro);
    }  
}
void descobrirMedia(string nomeDoCarro)
{
    if (vendasCarros.ContainsKey(nomeDoCarro))
    {
        List<int> qtdeVezesVenda = vendasCarros[nomeDoCarro];
        double mediaVenda = qtdeVezesVenda.Average();
        Console.WriteLine($"\nMedia de vendas : {mediaVenda}");
    }
    else
    {
        Console.WriteLine("Carro não encontrado.");
    }
    Thread.Sleep(2000);
    Console.WriteLine("\nDigite qualquer tecla para continuar.");
    Console.ReadKey(true);
    inicio();
}

inicio();

