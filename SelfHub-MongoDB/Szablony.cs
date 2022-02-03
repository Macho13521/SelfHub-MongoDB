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
        public List<Oceny> Oceny { get; set; }
    }

    public class Oceny
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string Przedmiot { get; set; }
        public int Ocena { get; set; }
    }
}
