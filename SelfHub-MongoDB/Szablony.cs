using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfHub_MongoDB
{
    public class Użytkownik
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public int Wiek { get; set; }
    }
}
