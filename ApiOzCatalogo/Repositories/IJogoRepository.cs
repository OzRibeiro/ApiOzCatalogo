using ApiOzCatalogo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOzCatalogo.Repositories
{
    public interface IJogoRepository : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(IJogoRepository jogo);
        Task Atualizar(IJogoRepository jogo);
        Task Remover(Guid id);
        Task Inserir(object jogoInsert);
        Task Atualizar(Jogo entidadeJogo);
    }
}
