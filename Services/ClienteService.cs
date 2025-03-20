using System.ComponentModel.DataAnnotations;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using pitaya_crud.Data;
using pitaya_crud.Models;

namespace pitaya_crud.Services
{
    internal class ClienteService
    {
        private readonly IMongoCollection<Cliente> _clientes;

        public ClienteService()
        {
            _clientes = new MongoDbContext().Clientes;
        }

        public async Task<Cliente> GetClienteByIdAsync(string id)
        {
            var cliente = await _clientes.Find(c => c.Id == id).FirstOrDefaultAsync()
                          ?? throw new KeyNotFoundException($"Cliente com id {id} não encontrado");
            return cliente;
        }

        // Esse método aceita parâmetro de ordenação por qualquer campo válido e
        // consulta por nome de cliente
        public async Task<List<Cliente>> GetClientesAsync(string? orderBy = null, string? nome = null)
        {
            var query = _clientes.AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                query = query.Where(c => c.Nome.Contains(nome));
            }

            query = orderBy?.ToLower() switch
            {
                "nome" => query.OrderBy(c => c.Nome),
                "idade" => query.OrderBy(c => c.Idade),
                "telefone" => query.OrderBy(c => c.Telefone),
                "fumante" => query.OrderBy(c => c.Fumante),
                "sexo" => query.OrderBy(c => c.Sexo),
                _ => query
            };

            return await query.ToListAsync();
        }


        public async Task DeleteClienteAsync(string id)
        {
            var result = await _clientes.DeleteOneAsync(c => c.Id == id);

            if (result.DeletedCount == 0)
                throw new KeyNotFoundException($"Cliente com ID {id} não encontrado.");
        }

        public async Task<Cliente?> CreateClienteAsync(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                throw new ValidationException("Dados invalidos");
            }

            await _clientes.InsertOneAsync(cliente);
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(string id, string field, object value)
        {
            var update = Builders<Cliente>.Update.Set(field, value);
            var result = await _clientes.FindOneAndUpdateAsync(
                c => c.Id == id,
                update,
                new FindOneAndUpdateOptions<Cliente> { ReturnDocument = ReturnDocument.After }
            );

            if (result == null)
                throw new KeyNotFoundException($"Cliente com ID {id} não encontrado ou não atualizado.");

            return result;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Id))
                throw new ArgumentException("ID do cliente não pode ser nulo ou vazio.");

            var result = await _clientes.FindOneAndReplaceAsync(
                c => c.Id == cliente.Id,
                cliente,
                new FindOneAndReplaceOptions<Cliente> { ReturnDocument = ReturnDocument.After }
            );

            if (result == null)
                throw new KeyNotFoundException($"Cliente com ID {cliente.Id} não foi atualizado.");

            return result;
        }



    }
}
