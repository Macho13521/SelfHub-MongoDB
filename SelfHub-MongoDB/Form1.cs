using MongoDB.Driver;
using static SelfHub_MongoDB.Mongo;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;

namespace SelfHub_MongoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Nasłuchiwanie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");

            Użytkownik osoba = new Użytkownik
            {
                ID = (ObjectId)new BsonObjectId(ObjectId.GenerateNewId()),  
                Login = dodanylogin.Text,
                Haslo = dodanehaslo.Text, 
                Email = dodanyemail.Text,
                Wiek = (int)dodanywiek.Value,
                Oceny = new List<Oceny>()
            };
            
            db.DodajDokument("Konta", osoba);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq(szukanepole.Text, szukanawartosc.Text);
            var znalezionydokument = db.SzukajDokumentów<Użytkownik>("Konta", filter).First();

            znalezioneID.Text = znalezionydokument.ID.ToString();
            znalezionylogin.Text = znalezionydokument.Login;
            znalezionehaslo.Text = znalezionydokument.Haslo;
            znalezionywiek.Text = znalezionydokument.Wiek.ToString();
            znalezionyemail.Text = znalezionydokument.Email;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            var aktualizacja = Builders<Użytkownik>.Update.Set(aktualizowanepole.Text, aktualizowanawartosc.Text);
            db.AktualizujDokumenty<Użytkownik>("Konta", filter, aktualizacja);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            db.UsuńDokument<Użytkownik>("Konta", filter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");

            Użytkownik osoba = new Użytkownik
            {
                ID = (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)),
                Login = aktualizacjaloginu.Text,
                Haslo = aktualizacjahasla.Text,
                Email = aktualizacjaemaila.Text,
                Wiek = (int)aktualizacjawieku.Value
            };

            var filter = Builders<Użytkownik>.Filter.Eq("_id", osoba.ID);
            db.PodmieńDokument<Użytkownik>("Konta",filter, osoba);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listadokumentow.Items.Clear();
            Mongo db = new Mongo("SelfHub");

            var filter = Builders<Użytkownik>.Filter.Eq(poleszukane.Text, wartosciszukane.Text);
            var dokumenty = db.SzukajDokumentów<Użytkownik>("Konta", filter);

            foreach (var dokument in dokumenty)
            {
                Console.WriteLine(dokument.Login + " " + dokument.Email);
                ListViewItem linijka = new ListViewItem();
                linijka.Text = dokument.Login;
                linijka.SubItems.Add(dokument.Email);
                linijka.SubItems.Add(dokument.Haslo);
                linijka.SubItems.Add(dokument.Wiek.ToString());
                listadokumentow.Items.Add(linijka);
            }
        }

        private async Task Nasłuchiwanie()
        {
            Mongo db = new Mongo("SelfHub");
            var kolekcja = db.db.GetCollection<Użytkownik>("Konta");

            using (var cursor = await kolekcja.WatchAsync())
            {
                await cursor.ForEachAsync(change =>
                {
                    MessageBox.Show("aktualizacja");
                });
            }

        }

        List<Użytkownik> dokumenty = new List<Użytkownik>();
        private void button7_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            db.DodajDokumenty("Konta",dokumenty);
            dokumenty.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Użytkownik osoba = new Użytkownik
            {
                Login = dodaneloginy.Text,
                Haslo = dodanehasla.Text,
                Email = dodaneemaile.Text,
                Wiek = (int)dodanewieki.Value
            };
            dokumenty.Add(osoba);
            dodaneloginy.Text = "";
            dodanehasla.Text = "";
            dodaneemaile.Text = "";
            dodanewieki.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq(usunwielepol.Text, usunwielewartosci.Text);
            db.UsuńDokumenty<Użytkownik>("Konta",filter);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq(szukaneaktualizacjepola.Text, szukaneaktualizacjewartosci.Text);
            var aktualizacja = Builders<Użytkownik>.Update.Set(aktualizacjepolek.Text,aktualizacjewartosci.Text);
            db.AktualizujDokumenty<Użytkownik>("Konta", filter, aktualizacja);
        }

        private void poleszukane_TextChanged(object sender, EventArgs e)
        {

        }

        private void wartosciszukane_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Oceny Ocenka = new Oceny
            {
                ID = (ObjectId)new BsonObjectId(ObjectId.GenerateNewId()),
                Przedmiot = kolejnyprzedmiot.Text,
                Ocena = (int)kolejnaocena.Value
            };
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            var aktualizacja = Builders<Użytkownik>.Update.AddToSet("Oceny",Ocenka);
            db.AktualizujDokumenty<Użytkownik>("Konta", filter, aktualizacja);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            var dokument = db.SzukajDokumentów<Użytkownik>("Konta", filter).First();

            znalezionaocena.Text = dokument.Oceny.Find(x => x.Przedmiot.Contains(szukanyprzedmiot.Text)).Ocena.ToString();
            idoceny.Text = dokument.Oceny.Find(x => x.Przedmiot.Contains(szukanyprzedmiot.Text)).ID.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<Użytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            var dokument = db.SzukajDokumentów<Użytkownik>("Konta", filter).First().Oceny;

            dokument.Remove(dokument.Find(x => x.ID.ToString().Contains(idoceny.Text)));

            var aktualizacja = Builders<Użytkownik>.Update.Set("Oceny", dokument);
            db.AktualizujDokumenty<Użytkownik>("Konta", filter, aktualizacja);
        }
    }
}