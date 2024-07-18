using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace BeeMVC.Models
{
    public class Register
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }

    }

    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
