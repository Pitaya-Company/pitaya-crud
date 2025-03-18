using MongoDB.Driver;
namespace pitaya_crud.Data;

public class MongoDbContext
{
    private readonly string _connectionUri = Environment.GetEnvironmentVariable("PITAYACONNECTIONSTRING") 
                                             ?? throw new ArgumentNullException("PITAYACONNECTIONSTRING não foi encontrada");
    private readonly IMongoDatabase _database;
    public MongoDbContext()
    {
        var client = new MongoClient(_connectionUri);
        _database = client.GetDatabase("PitayaCompanyDb");
    }

    public IMongoCollection<Usuario> Usuarios => _database.GetCollection<Usuario>("usuarios");
}