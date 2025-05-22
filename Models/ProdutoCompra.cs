using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pitaya_crud.Models
{
    public class ProdutoCompra
    {
        [BsonElement("produto_id")]
        public string ProdutoId { get; set; }

        [BsonElement("nome_produto")]
        public string NomeProduto { get; set; }

        [BsonElement("quantidadep")]
        public int QuantidadeP { get; set; }
    }
}
