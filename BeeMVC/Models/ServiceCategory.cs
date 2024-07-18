using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BeeMVC.Models
{
    public class ServiceCategory : DefautProperty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public WorkerType Type { get; set; }
        public SubCategoryType SubCategoryType { get; set; }
    }
    public enum SubCategoryType
    {
        AcRepairing,
        Refriserator,
        TvReparing,
        WashingMachine,
        CarWashing,
        BikeRepairing,
        BikeWashing,
        carRepairing,
        Carpenter,
    }
}
