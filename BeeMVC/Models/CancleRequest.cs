using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BeeMVC.Models
{
    public class CancleRequest: DefautProperty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {  get; set; } 
        public string Name { get; set; }
        public SubCategoryType SubCategoryType { get; set; }
        public string Reason { get; set; }
    }
}
