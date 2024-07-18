using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BeeMVC.Models
{
    public class WorkerInfo : DefautProperty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  PhoneNumber { get; set; }
        public string Address { get; set; }
        public WorkerType WorkerType { get; set; }
    }
    public enum WorkerType
    {
        Mechenical,
        Electrician,
        Plumber,
        Labour,
        Operator,
        Washer,
        Other
    }
}
