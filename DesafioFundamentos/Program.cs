using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
//precoInicial = Convert.ToDecimal(Console.ReadLine());
// Valida se o valor é numérico e positivo, se não for, solicita novamente

while (!decimal.TryParse(Console.ReadLine(), out precoInicial) || precoInicial < 0)
{
    Console.WriteLine("Valor inválido. Por favor, digite um valor numérico positivo para o preço inicial:");
}

Console.WriteLine("Agora digite o preço por hora:");
//precoPorHora = Convert.ToDecimal(Console.ReadLine());
// Valida se o valor é numérico e positivo, se não for, solicita novamente

while (!decimal.TryParse(Console.ReadLine(), out precoPorHora) || precoPorHora < 0)
{
    Console.WriteLine("Valor inválido. Por favor, digite um valor numérico positivo para o preço por hora:");
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    try
    {
        Console.Clear();
    }
    catch (IOException)
    {
        // Ignora se não for possível limpar o console
        Console.WriteLine("Não foi possível limpar o console. Continuando...");
    }
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
Console.WriteLine("Obrigado por utilizar o sistema de estacionamento!");
Console.WriteLine("Pressione uma tecla para sair");
Console.ReadLine();
Environment.Exit(0);
// O Environment.Exit(0) é usado para encerrar o programa com um código de saída 0, indicando sucesso.
// O Console.ReadLine() é usado para aguardar o usuário pressionar uma tecla antes de sair, garantindo que a mensagem final seja visível antes do encerramento do programa.
