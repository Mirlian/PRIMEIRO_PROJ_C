// Screen Sound Teste Git
using System.Net.Http.Headers;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string>listaDasBandas = new List<string> { "Daniel", "Leonardo" };

Dictionary<string, List<double>> bandasRegistradas = new Dictionary<string, List<double>>();
bandasRegistradas.Add("Ze Felipe", new List<double>  { 10,8,6});
bandasRegistradas.Add("Jorge e Mateus", new List<double>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}// funcão sem nenhum retorno

//ExibirMensagemDeBoasVindas();

void ExibirTitulodaOpcao(string titulo)
{
    int qtdeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");//\n pular linha
    Console.WriteLine("Digita 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir uma média de uma banda");
    Console.WriteLine("Digite -1 para sair");


    Console.Write("\nDigite a sua opção: "); 
    string opcaoEscolhida = Console.ReadLine()!; // ! para não retornar valor nulo
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    //    if (opcaoEscolhidaNumerica == 1)
    //    {
    //        Console.WriteLine("Você digitou a opção "+opcaoEscolhida);
    //    }
    //    else if (opcaoEscolhidaNumerica == 2)
    //   {
    //       Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    //   }

    /*  
       switch (opcaoEscolhidaNumerica)
       {
           case 1: RegistrarBanda();
               //Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
               Console.WriteLine("Você escolheu a opção: {0}", opcaoEscolhidaNumerica); // substitui marcadores posição {0}, {1}..
               break;
           case 2:
               //Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
               Console.WriteLine($"Você digitou a oção: {opcaoEscolhidaNumerica}"); //interpolação, incluir variavel diretamente e uma string usando {} 
               break;
           case 3:
               Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
               break;
           case 4:
               Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
               break;
           case -1:
               Console.WriteLine("Fim");
               break;
           default: 
               Console.WriteLine("Opção Inválida");
               break;
       }
   */
    switch (opcaoEscolhidaNumerica)
    {
        case 1:  RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4:
            MostrarMediaDeUmaBanda();
            break;
        case -1:
            Console.WriteLine("Fim");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulodaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: "); // write = não pula linha
    string nomeDaBanda = Console.ReadLine()!; // ! não quero trabalhar com valores nulos.
    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda,new List<double>());
    Console.WriteLine($"A banda foi registrada com sucesso! {nomeDaBanda}");
    Thread.Sleep(2000); // aguardar em milisegundos
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulodaOpcao("Exibindo todas as bandas registradas");
    //    for (int i = 0; i < listaDasBandas.Count; i++)
    //    {
    //        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //    }
    //   { 
    //   foreach(string banda in listaDasBandas)
    //   {
    //       Console.WriteLine($"Banda: {banda}");
    //   }
      foreach(string banda in bandasRegistradas.Keys)
      {
          Console.WriteLine($"Banda: {banda}");
      }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    // digite qual banda deseja avaliar
    // se a banda existir no dicionário >> atribuir uma nota
    // se não existir exibe msg e volta ao menu principal.
    Console.Clear();
    ExibirTitulodaOpcao("Avaliar banda");

    Console.Write("Digite o nome da banda que seja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        double nota = double.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey(true);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

 }

void MostrarNotasDaBanda(string nomeDaBanda)
{
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nNotas de {nomeDaBanda}: ");
        foreach (double nota in bandasRegistradas[nomeDaBanda])
        {
            Console.Write($"{nota} ");
        }
    }
}

void MostrarMediaDeUmaBanda ()
{
    Console.Clear();
    ExibirTitulodaOpcao("Media de Uma Banda");

    Console.Write("Digite o nome da banda que deseja exibir uma média das notas: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<double> notaTotalDasBandas = bandasRegistradas[nomeDaBanda];
        double mediaNotaBanda = notaTotalDasBandas.Average();

        MostrarNotasDaBanda(nomeDaBanda);
        Console.WriteLine($"\n\nA média da nota é: {mediaNotaBanda}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey(true);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey(true);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
    
ExibirOpcoesDoMenu();