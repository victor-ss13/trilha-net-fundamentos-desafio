namespace DesafioFundamentos.Models
{
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
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Capta a entrada do usuário, permitindo que seja nula e converte para maiúsculas
            string? placa = Console.ReadLine()?.ToUpper();;

            // verifica se a placa é nula ou vazia, se for exibe erro
            if (string.IsNullOrWhiteSpace(placa))   
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            // Adiciona a placa à lista de veículos
            veiculos.Add(placa);

            // Exibe mensagem de sucesso
            Console.WriteLine($"Veículo {placa} cadastrado com sucesso");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string? placa = Console.ReadLine()?.ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Capta a entrada do usuário, convertendo de string para inteiro
                int horas = Convert.ToInt32(Console.ReadLine());;
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Itera sobre cada veículo na lista, adicionando cada placa à variável 'veiculo' e depois exibe no console
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Veículo placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
