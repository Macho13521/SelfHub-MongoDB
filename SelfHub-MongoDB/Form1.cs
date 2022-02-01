using static SelfHub_MongoDB.Mongo;

namespace SelfHub_MongoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            U�ytkownik osoba = new U�ytkownik
            {
                Login = dodanylogin.Text,
                Haslo = dodanehaslo.Text, 
                Email = dodanyemail.Text,
                Wiek = (int)dodanywiek.Value
            };
            db.DodajDokument("Konta", osoba);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            var znalezionydokument = db.SzukajDokumentu<U�ytkownik>("Konta", szukanepole.Text, szukanawartosc.Text);

            znalezioneID.Text = znalezionydokument.id.ToString();
            znalezionylogin.Text = znalezionydokument.Login;
            znalezionehaslo.Text = znalezionydokument.Haslo;
            znalezionywiek.Text = znalezionydokument.Wiek.ToString();
            znalezionyemail.Text = znalezionydokument.Email;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            db.AktualizujDokument<U�ytkownik>("Konta", "id", znalezioneID.Text, aktualizowanepole.Text, aktualizowanawartosc.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mongo db = new Mongo("SelfHub");
            db.Usu�Dokument<U�ytkownik>("Konta", "id", znalezioneID.Text);
        }
    }
}