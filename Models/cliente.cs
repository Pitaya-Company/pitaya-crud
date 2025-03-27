using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pitaya_crud.Models
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nome")]
        public required string Nome { get; set; }

        [BsonElement("idade")]
        public required int Idade { get; set; }
    
        [BsonElement("telefone")]
        public required string Telefone { get; set; }

        [BsonElement("fumante")]
        public required bool Fumante { get; set; }

        [BsonElement("sexo")]
        public required  string Sexo { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Nome)) return false;
            if(Idade <= 0) return false;
            if (string.IsNullOrWhiteSpace(Telefone)) return false;
            return !string.IsNullOrWhiteSpace(Sexo);
        }
    }

}
