namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        /// <summary>
        /// Representa os hóspedes da reserva.
        /// </summary>
        public List<Pessoa> Hospedes { get; set; }

        /// <summary>
        /// Representa a suíte da reserva.
        /// </summary>
        public Suite Suite { get; set; }

        /// <summary>
        /// Representa a quantidade de dias reservados.
        /// </summary>
        public int DiasReservados { get; set; }

        /// <summary>
        /// Construtor padrão de Reserva.
        /// </summary>
        public Reserva() { }

        /// <summary>
        /// Cria uma nova instância de Reserva com a quantidade de dias reservados.
        /// </summary>
        /// <param name="diasReservados">A quantidade de dias que a suíte será reservada.</param>
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        /// <summary>
        /// Cadastra os hóspedes da reserva, desde que a capacidade da suíte seja maior ou igual ao número de hóspedes.
        /// </summary>
        /// <param name="hospedes">Lista de hóspedes da reserva.</param>
        /// <exception cref="Exception">Lançada quando a capacidade da suíte é menor que o número de hóspedes.</exception>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        /// <summary>
        /// Cadastra a suíte da reserva.
        /// </summary>
        /// <param name="suite">Suíte da reserva.</param>
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        /// <summary>
        /// Retorna a quantidade de hóspedes da reserva.
        /// </summary>
        /// <returns>Quantidade de hóspedes.</returns>
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        /// <summary>
        /// Calcula o valor da diária da reserva.
        /// </summary>
        /// <returns>O valor da diária, com desconto de 10% para 10 ou mais dias.</returns>
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.9m;
            }

            return valor;
        }
    }
}