using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pitaya_crud.Models
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CodigoProduto 
        { 
            get; set; 
        }

        [BsonElement("nome_produto")]
        public required string NomeProduto 
        { 
            get; set; 
        }

        [BsonElement("valor")]
        public int Valor
        {
            get; set;
        }

        [BsonElement("quantidade")]
        public int Quantidade
        {
            get; set;
        }
    }

}
