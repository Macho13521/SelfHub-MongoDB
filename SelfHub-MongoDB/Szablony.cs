using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHub_MongoDB
{
    public class Użytkownik
    {
        [BsonId]
        public Guid id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public int Wiek { get; set; }
    }
}
