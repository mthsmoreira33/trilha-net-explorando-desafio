namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

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