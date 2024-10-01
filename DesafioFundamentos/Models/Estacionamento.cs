namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Responsável pelo gerenciamento dos veículos
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Método Construtor do Estacionamento
        /// </summary>
        /// <param name="precoInicial">Preço base do estacionamento</param>
        /// <param name="precoPorHora">Preço por hora do estacionamento</param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adiciona um veíulo à lista
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            this.veiculos.Add(Console.ReadLine());
        }

        /// <summary>
        /// Remove um veículo da lista, mostrando o valor a ser pago pelo cliente
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = this.precoInicial +this.precoPorHora*horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// Imprime os veículos na lista
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (String veiculo in veiculos)
                {
                    Console.Write(veiculo + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
