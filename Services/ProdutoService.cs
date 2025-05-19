using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using pitaya_crud.Data;
using pitaya_crud.Models;

namespace pitaya_crud.Services
{
    internal class ProdutoService
    {
        private readonly IMongoCollection<Produto> _produtos;

        public ProdutoService()
        {
            _produtos = new MongoDbContext().Produtos;
        }

        public async Task<Produto> GetProdutoByCodigoAsync(string codigo)
        {
            var produto = await _produtos.Find(p => p.CodigoProduto == codigo).FirstOrDefaultAsync()
                          ?? throw new KeyNotFoundException($"Produto com código {codigo} não encontrado");
            return produto;
        }

        public async Task<List<Produto>> GetProdutosAsync(string? orderBy = null, string? nome = null)
        {
            var query = _produtos.AsQueryable();
            Debug.WriteLine($"Query inicial: {query}");

            if (!string.IsNullOrWhiteSpace(nome))
            {
                nome = nome.ToLower();
                query = query.Where(p => p.NomeProduto.ToLower().Contains(nome));
                Debug.WriteLine($"Filtro de nome ativado com {nome}");
            }

            query = orderBy?.ToLower() switch
            {
                "codigo" => query.OrderBy(p => p.CodigoProduto),
                "nome" => query.OrderBy(p => p.NomeProduto),
                "valor" => query.OrderBy(p => p.Valor),
                "quantidade" => query.OrderBy(p => p.Quantidade),
                _ => query
            };

            var produtos = await query.ToListAsync();
            Debug.WriteLine($"LISTA DE PRODUTOS: {produtos.Count} itens carregados");
            return produtos;
        }

        public async Task<Produto> CreateProdutoAsync(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.NomeProduto))
            {
                throw new ValidationException("Produto inválido: nome é obrigatório.");
            }

            await _produtos.InsertOneAsync(produto);
            return produto;
        }

        public async Task<Produto> UpdateProdutoAsync(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.CodigoProduto))
                throw new ArgumentException("Código do produto não pode ser nulo ou vazio.");

            var result = await _produtos.FindOneAndReplaceAsync(
                p => p.CodigoProduto == produto.CodigoProduto,
                produto,
                new FindOneAndReplaceOptions<Produto> { ReturnDocument = ReturnDocument.After }
            ) ?? throw new KeyNotFoundException($"Produto com código {produto.CodigoProduto} não encontrado.");

            return result;
        }

        public async Task DeleteProdutoAsync(string codigo)
        {
            var result = await _produtos.DeleteOneAsync(p => p.CodigoProduto == codigo);

            if (result.DeletedCount == 0)
                throw new KeyNotFoundException($"Produto com código {codigo} não encontrado.");
        }
    }
}
