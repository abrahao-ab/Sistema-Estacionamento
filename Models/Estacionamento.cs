namespace SistemaEstacionamento.Models;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();


    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar: ");
        string veiculoEntrando = Console.ReadLine();

            if(veiculos.Contains(veiculoEntrando))
            {
                Console.WriteLine("Veículo já cadastrado!");
                Console.WriteLine("Presisone Qualquer Tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
                AdicionarVeiculo();
            }
            else
            {
                veiculos.Add(veiculoEntrando);
                Console.WriteLine($"O veículo {veiculoEntrando} foi registrado com sucesso!");
            }
            Console.WriteLine("Deseja cadastrar outro veículo?\n1- Sim\n2- Não");
            string resposta = Console.ReadLine();
            if(resposta == "1")
            {
                Console.Clear();
                AdicionarVeiculo();
            }

        
    }
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover: ");
        string veiculoSaindo = Console.ReadLine();
        if(veiculos.Contains(veiculoSaindo))
        {
            veiculos.Remove(veiculoSaindo);
            Console.WriteLine("Por quanto tempo (em horas) este veículo ficou?");
            int horasPermanecidas = Convert.ToInt32(Console.ReadLine());
            if(horasPermanecidas == 0)
            {
                Console.WriteLine($"O valor que este cliente deve pagar é de: R$ {precoInicial}");
            }
            else
            {
                decimal valorTotal = (horasPermanecidas*precoPorHora) + precoInicial;
                Console.WriteLine($"O valor que este cliente deve pagar é de: R$ {valorTotal}");

            }
            Console.WriteLine($"O veículo de placa {veiculoSaindo} foi removido com sucesso!");
        }
        else
        {
            Console.WriteLine($"O veículo {veiculoSaindo} não foi cadastrado em nosso sistema!");   
        }
    }
    public void ListarVeiculo()
    {
        Console.WriteLine("Listando todos os veículos logo abaixo: ");
        foreach(string veiculo in veiculos)
        {
            Console.WriteLine($"- {veiculo}");
        }
    }
}