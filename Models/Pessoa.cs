namespace DesafioProjetoHospedagem.Models;

/// <summary>
/// Representa uma pessoa, como um hóspede.
/// </summary>
public class Pessoa
{
    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Pessoa"/>.
    /// </summary>
    public Pessoa() { }

    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Pessoa"/> com o nome.
    /// </summary>
    /// <param name="nome">O primeiro nome da pessoa.</param>
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Pessoa"/> com o nome e sobrenome.
    /// </summary>
    /// <param name="nome">O primeiro nome da pessoa.</param>
    /// <param name="sobrenome">O sobrenome da pessoa.</param>
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    /// <summary>
    /// Obtém ou define o primeiro nome da pessoa.
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Obtém ou define o sobrenome da pessoa.
    /// </summary>
    public string Sobrenome { get; set; }

    /// <summary>
    /// Obtém o nome completo da pessoa em letras maiúsculas.
    /// </summary>
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}