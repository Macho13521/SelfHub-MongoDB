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
        public IMongoDatabase db;

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

        public void UsuńDokument<T>(string table, FilterDefinition<T> filter)
        {
            var kolekcja = db.GetCollection<T>(table);
            kolekcja.DeleteOne(filter);
        }

        public void PodmieńDokument<T>(string table, FilterDefinition<T> filter, T dane)
        {
            var kolekcja = db.GetCollection<T>(table);
            kolekcja.ReplaceOne(filter, dane);
        }

        public List<T> SzukajDokumentów<T>(string table, FilterDefinition<T> filter)
        {
            var kolekcja = db.GetCollection<T>(table);
            return kolekcja.Find(filter).ToList();
        }
        public List<T> WszystkieDokumenty<T>(string table)
        {
            var kolekcja = db.GetCollection<T>(table);
            return kolekcja.Find(new BsonDocument()).ToList();
        }

        public void DodajDokumenty<T>(string table, List<T> dokumenty)
        {
            var kolekcja = db.GetCollection<T>(table);
            kolekcja.InsertMany(dokumenty);
        }
        public void UsuńDokumenty<T>(string table, FilterDefinition<T> filter)
        {
            var kolekcja = db.GetCollection<T>(table);
            kolekcja.DeleteMany(filter);
        }

        public void AktualizujDokumenty<T>(string table, FilterDefinition<T> filter, UpdateDefinition<T> aktualizacja)
        {
            var kolekcja = db.GetCollection<T>(table);
            kolekcja.UpdateMany(filter, aktualizacja);
        }
    }
}
