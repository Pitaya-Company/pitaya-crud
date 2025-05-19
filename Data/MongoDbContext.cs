using MongoDB.Driver;
using pitaya_crud.Models;
namespace pitaya_crud.Data;

public class MongoDbContext
{
    private readonly string _connectionUri = Environment.GetEnvironmentVariable("PITAYACONNECTIONSTRING")
                                             ?? throw new ArgumentNullException("PITAYACONNECTIONSTRING n�o foi encontrada");

    private readonly IMongoDatabase _database;
    public MongoDbContext()
    {
        var client = new MongoClient(_connectionUri);
        _database = client.GetDatabase("PitayaCompanyDb");
    }

    public IMongoCollection<Usuario> Usuarios => _database.GetCollection<Usuario>("usuarios");
    public IMongoCollection<Cliente> Clientes => _database.GetCollection<Cliente>("clientes");
    public IMongoCollection<Compra> Compras => _database.GetCollection<Compra>("compras");
    public IMongoCollection<Produto> Produtos => _database.GetCollection<Produto>("produtos");
}

