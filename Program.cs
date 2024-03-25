using SistemaEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n"+
                  "Digite o preço inicial: ");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirmenu = true;

while(exibirmenu)
{
    Console.Clear();
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1- Cadastrar veículo");
    Console.WriteLine("2- Remover veículo");
    Console.WriteLine("3- Listar veículos");
    Console.WriteLine("4- Encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        
        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculo();
            break;
        
        case "4":
            exibirmenu = false;
            break;

        default:
        Console.WriteLine("Opção Inválida!");
        break;
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadLine();

}
            Console.WriteLine("Encerrando Sistema.");
