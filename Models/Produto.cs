using MongoDB.Bson.Serialization.Attributes;

namespace pitaya_crud.Models
{
    public class Produto
    {
        [BsonElement("codigo_produto")]
        public string CodigoProduto 
        { 
            get; set; 
        }

        [BsonElement("nome_produto")]
        public string NomeProduto 
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
