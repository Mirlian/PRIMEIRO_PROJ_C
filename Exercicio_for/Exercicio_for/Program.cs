
List<int> listaDeNumeros = new List<int>();

string msgInicial = "Bem vindo !";
void MostraLogo()
{
    Console.WriteLine(@"
█▀▀ ▀▄▀ █▀▀ █▀█ █▀▀ █ █▀▀ █ █▀█   █░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀▀   █▀█ █▀▀ █▀█ █▀▀ ▀█▀ █ █▀▀ █▀█ █▀▀ █▀
██▄ █░█ ██▄ █▀▄ █▄▄ █ █▄▄ █ █▄█   █▄▄ █ ▄█ ░█░ █▀█   █▄▀ ██▄   █▀▄ ██▄ █▀▀ ██▄ ░█░ █ █▄▄ █▄█ ██▄ ▄█
");
    Console.WriteLine(msgInicial);
}

void DigiteUmaTecla()
{
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
}
void MostraNumeros()
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("Exibindo Número(s) Registrado(s)");
    Console.WriteLine("********************************\n");

    for (int i = 0; i < listaDeNumeros.Count; i++)
    {
        Console.WriteLine($"Numero: {listaDeNumeros[i]}");
    }
    DigiteUmaTecla();
    ExibirOpcoes();
}

void MostraNumerosInteiros()
{
    Console.Clear();
    Console.WriteLine("****************************************");
    Console.WriteLine("Exibindo Número(s) Par(es) Registrado(s)");
    Console.WriteLine("****************************************\n");
    foreach (int numero in listaDeNumeros)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"Número {numero}");
        }
    }
    DigiteUmaTecla();
    ExibirOpcoes();
}
void ExibirOpcoes()
{
    MostraLogo();
    Console.WriteLine("\nDigite 1 para registrar um número");
    Console.WriteLine("Digite 2 para exibir números");
    Console.WriteLine("Digite 3 para exibir números pares");
    Console.WriteLine("Digite -1 para sair");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarNumeros();
            break;
        case 2: MostraNumeros();
            break;
        case 3: MostraNumerosInteiros();
            break;
        case -1: Console.WriteLine("Fim");
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
}
void RegistrarNumeros()
{
    Console.Clear();
    Console.WriteLine("Registro de numeros");
    Console.Write("Digite o número que deseja registrar: ");
    string numero = Console.ReadLine()!;
    listaDeNumeros.Add(int.Parse(numero));
    Console.WriteLine($"O número {numero} foi registrado");
    Console.Clear();
    Thread.Sleep(2000);
    ExibirOpcoes();
}

ExibirOpcoes();
