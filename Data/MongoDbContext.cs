using MongoDB.Driver;

namespace pitaya_crud.Data;

public class MongoDbContext
{
    const string connectionUri = "mongodb+srv://pitayacompany:pc0pc1pc2@clusterpitayacompany.b2gw2.mongodb.net/?appName=ClusterPitayaCompany";
    private readonly IMongoDatabase _database;
    public MongoDbContext()
    {
        var client = new MongoClient(connectionUri);
        _database = client.GetDatabase("PitayaCompanyDb");
    }

    public IMongoCollection<Usuario> Usuarios => _database.GetCollection<Usuario>("usuarios");
}