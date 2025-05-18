using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pitaya_crud.Models
{
    public class Compra
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("cliente_id")]
        public required string ClienteId { get; set; }

        [BsonElement("produtos")] 
        public List<ProdutoCompra> Produtos { get; set; } = [];

        [BsonElement("data")]
        public DateTime Data { get; set; } = DateTime.UtcNow;

        [BsonElement("total")] 
        public decimal Total { get; set; } = 0.00m;
    }
}
