using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pitaya_crud.Models
{
public class Cliente
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public required string Id { get; set; }

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
}
}
