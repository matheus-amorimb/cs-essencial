namespace PrimeiraApi.Models;

public class CadastroPessoa
{
    public string Nome { get; set;}
    public string? Telefone { get; set;}
    public string? Email { get; set; }

    public CadastroPessoa(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}