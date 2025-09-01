namespace DesafioProjetoHospedagem.Models
{
    /// <summary>
    /// Representa uma suíte de hotel.
    /// </summary>
    public class Suite
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Suite"/>.
        /// </summary>
        public Suite() { }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Suite"/> com o tipo, capacidade e valor da diária.
        /// </summary>
        /// <param name="tipoSuite">O tipo da suíte (e.g., Premium, Standard).</param>
        /// <param name="capacidade">A capacidade de hóspedes da suíte.</param>
        /// <param name="valorDiaria">O valor da diária da suíte.</param>
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        /// <summary>
        /// Obtém ou define o tipo da suíte.
        /// </summary>
        public string TipoSuite { get; set; }

        /// <summary>
        /// Obtém ou define a capacidade de hóspedes da suíte.
        /// </summary>
        public int Capacidade { get; set; }

        /// <summary>
        /// Obtém ou define o valor da diária da suíte.
        /// </summary>
        public decimal ValorDiaria { get; set; }
    }
}
