using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace SelfHub_MongoDB
{
    public class Mongo
    {
        private IMongoDatabase db;

        public Mongo(string bazadanych)
        {
            var klient = new MongoClient("mongodb+srv://Apeczka:e9EnsODP1IZatvlM@cluster0.g3xgg.mongodb.net/test");
            db = klient.GetDatabase(bazadanych);
        }

        public void DodajDokument<T>(string table, T dane)
        {
            var kolekcja = db.GetCollection<T>(table);
            kolekcja.InsertOne(dane);
        }

        public T SzukajDokumentu<T>(string table, string Pole, string Wartosc)
        {
            var kolekcja = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(Pole, Wartosc);
            return kolekcja.Find(filter).First();
        }

        public void AktualizujDokument<T>(string table, string Indeks, dynamic Wartosc, string indekskolumny, dynamic wartosc2)
        {
            var kolekcja = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(Indeks, Wartosc);
            var aktualizacja = Builders<T>.Update.Set(indekskolumny,wartosc2);
            kolekcja.UpdateOne(filter, aktualizacja);
        }

        public void UsuńDokument<T>(string table, string Indeks, dynamic Wartosc)
        {
            var kolekcja = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(Indeks, Wartosc);
            kolekcja.DeleteOne(filter);
        }

        public void PodmieńDokument<T>(string table, string Indeks, string Wartość, T dane)
        {
            var kolekcja = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(Indeks, Wartość);
            kolekcja.ReplaceOne(filter, dane);
        }

        public List<T> SzukajDokumentów<T>(string table, dynamic danefiltra)
        {
            var kolekcja = db.GetCollection<T>(table);
            FilterDefinition<T> filter = danefiltra;
            return kolekcja.Find(filter).ToList();
        }
        public List<T> WszystkieDokumenty<T>(string table)
        {
            var kolekcja = db.GetCollection<T>(table);
            return kolekcja.Find(new BsonDocument()).ToList();
        }
    }
}
