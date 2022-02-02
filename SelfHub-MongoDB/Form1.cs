using MongoDB.Driver;
using static SelfHub_MongoDB.Mongo;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfHub_MongoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Nas³uchiwanie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            U¿ytkownik osoba = new U¿ytkownik
            {
                ID = (ObjectId)new BsonObjectId(ObjectId.GenerateNewId()),  
                Login = dodanylogin.Text,
                Haslo = dodanehaslo.Text, 
                Email = dodanyemail.Text,
                Wiek = (int)dodanywiek.Value
            };
            db.DodajDokument("Konta", osoba);
            MessageBox.Show(osoba.ID.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<U¿ytkownik>.Filter.Eq(szukanepole.Text, szukanawartosc.Text);
            var znalezionydokument = db.SzukajDokumentów<U¿ytkownik>("Konta", filter).First();

            znalezioneID.Text = znalezionydokument.ID.ToString();
            znalezionylogin.Text = znalezionydokument.Login;
            znalezionehaslo.Text = znalezionydokument.Haslo;
            znalezionywiek.Text = znalezionydokument.Wiek.ToString();
            znalezionyemail.Text = znalezionydokument.Email;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<U¿ytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            var aktualizacja = Builders<U¿ytkownik>.Update.Set(aktualizowanepole.Text, aktualizowanawartosc.Text);
            db.AktualizujDokumenty<U¿ytkownik>("Konta", filter, aktualizacja);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<U¿ytkownik>.Filter.Eq("_id", (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)));
            db.UsuñDokument<U¿ytkownik>("Konta", filter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");

            U¿ytkownik osoba = new U¿ytkownik
            {
                ID = (ObjectId)new BsonObjectId(ObjectId.Parse(znalezioneID.Text)),
                Login = aktualizacjaloginu.Text,
                Haslo = aktualizacjahasla.Text,
                Email = aktualizacjaemaila.Text,
                Wiek = (int)aktualizacjawieku.Value
            };

            var filter = Builders<U¿ytkownik>.Filter.Eq("_id", osoba.ID);
            db.PodmieñDokument<U¿ytkownik>("Konta",filter, osoba);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listadokumentow.Items.Clear();
            Mongo db = new Mongo("SelfHub");

            var filter = Builders<U¿ytkownik>.Filter.Eq(poleszukane.Text, wartosciszukane.Text);
            var dokumenty = db.SzukajDokumentów<U¿ytkownik>("Konta", filter);

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

        private async Task Nas³uchiwanie()
        {
            Mongo db = new Mongo("SelfHub");
            var kolekcja = db.db.GetCollection<U¿ytkownik>("Konta");

            using (var cursor = await kolekcja.WatchAsync())
            {
                await cursor.ForEachAsync(change =>
                {
                    MessageBox.Show("aktualizacja");
                });
            }

        }

        List<U¿ytkownik> dokumenty = new List<U¿ytkownik>();
        private void button7_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            db.DodajDokumenty("Konta",dokumenty);
            dokumenty.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            U¿ytkownik osoba = new U¿ytkownik
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
            var filter = Builders<U¿ytkownik>.Filter.Eq(usunwielepol.Text, usunwielewartosci.Text);
            db.UsuñDokumenty<U¿ytkownik>("Konta",filter);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var filter = Builders<U¿ytkownik>.Filter.Eq(szukaneaktualizacjepola.Text, szukaneaktualizacjewartosci.Text);
            var aktualizacja = Builders<U¿ytkownik>.Update.Set(aktualizacjepolek.Text,aktualizacjewartosci.Text);
            db.AktualizujDokumenty<U¿ytkownik>("Konta", filter, aktualizacja);
        }
    }
}