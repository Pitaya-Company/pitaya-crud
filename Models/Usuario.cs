using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace pitaya_crud.Models
{
    public class Usuario
    {
        [BsonId] // define ID único do documento no MongoDB
        [BsonRepresentation(BsonType.ObjectId)] // converte automaticamente string para ObjectId
        public string Id { get; set; }

        [BsonElement("email")]
        public required string Email { get; set; }

        [BsonElement("senha")]
        public required string Senha { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Email)) return false;
            if (string.IsNullOrWhiteSpace(Senha)) return false;
            return true;
        }
    }
}
