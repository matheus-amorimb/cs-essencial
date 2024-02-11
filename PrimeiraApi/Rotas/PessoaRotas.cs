using Microsoft.AspNetCore.Builder;
using PrimeiraApi.Models;
using System.Collections.Generic;

namespace PrimeiraApi.Rotas
{
    public static class PessoaRotas
    {
        public static List<CadastroPessoa> Cadastros = new List<CadastroPessoa>();

        public static void MapPessoaRotas(this WebApplication app)
        {
            app.MapPost("/cadastrarPessoas", (CadastroPessoa cadastro) =>
            {
                CadastroPessoa novaPessoa = new CadastroPessoa(
                    cadastro.Nome,
                    cadastro.Telefone,
                    cadastro.Email
                );

                Cadastros.Add(novaPessoa);

                return Cadastros;
            });
        }
    }
}