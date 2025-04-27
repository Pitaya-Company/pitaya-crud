using MongoDB.Driver;
using pitaya_crud.Models;
using pitaya_crud.Data;
using MongoDB.Driver.Linq;

namespace pitaya_crud.Services
{
    public class CompraService
    {
        private readonly IMongoCollection<Compra> _compras;
        public CompraService()
        {
            _compras = new MongoDbContext().Compras;
        }

        public async Task<Compra> GetCompraByIdAsync(string id)
        {
            var compra = await _compras.Find(c => c.Id == id).FirstOrDefaultAsync()
                          ?? throw new KeyNotFoundException($"Compra com id {id} não encontrada");
            return compra;
        }

        public async Task<List<Compra>> GetComprasAsync(string? orderBy = null, string? clienteId = null)
        {
            var query = _compras.AsQueryable();

            if (!string.IsNullOrWhiteSpace(clienteId))
            {
                query = query.Where(c => c.ClienteId == clienteId);
            }

            query = orderBy?.ToLower() switch
            {
                "data" => query.OrderBy(c => c.Data),
                "valor" => query.OrderBy(c => c.Total),
                _ => query
            };

            var compras = await query.ToListAsync();
            return compras;
        }

        public async Task<Compra> CreateCompraAsync(Compra compra)
        {
            await _compras.InsertOneAsync(compra);
            return compra;
        }

        public async Task DeleteCompraAsync(string id)
        {
            var result = await _compras.DeleteOneAsync(c => c.Id == id);

            if (result.DeletedCount == 0)
                throw new KeyNotFoundException($"Compra com ID {id} não encontrada.");
        }

        public async Task<Compra> UpdateCompraAsync(Compra compra)
        {
            var result = await _compras.FindOneAndReplaceAsync(
                c => c.Id == compra.Id, 
                compra,
                new FindOneAndReplaceOptions<Compra>
                {
                    ReturnDocument = ReturnDocument.After
                }) ?? throw new KeyNotFoundException($"Compra com ID {compra.Id} não encontrada."); 

            return compra;
        }

    }
}