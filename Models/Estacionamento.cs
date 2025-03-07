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
            //Implementado
            // TODO: Pedir para o usuário digitar uma placa(ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar");

            //Implementado
            
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine("Véiculo estacionado com Sucesso! ");

        }

        public void RemoverVeiculo()
        {
            //Implememntado 
            // Pedir para o usuário digitar a placa e armazenar na variável placa

            Console.WriteLine("Digite a placa do veículo para remover:");

            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço inicial:");
                decimal precoInicial = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço por hora:");
                decimal precoPorHora = decimal.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remover a placa digitada da lista de veículos
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*


                //Implementado

                //Itera sobre cada veículo in veiculos

                foreach (var placa in veiculos)
                {
                    //Exibe qual a placa do Véiculo

                    Console.WriteLine($"Os véiculos estacionados são: {placa}");

                };

                

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
