using MongoDB.Driver;

namespace BeeMVC.Models
{
    public class BeeDbContext
    {
        public IMongoDatabase db;
        public BeeDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("Bee");
            Signup = db.GetCollection<Register>("signup");

        }
        public IMongoCollection<Register> Signup { get; set; }
    }
}
