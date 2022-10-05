namespace la_mia_pizzeria_post.Models
{
    public class Pizza
    {
        public Pizza()
        {
        }

        public Pizza(string nome, string descrizione, string foto, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Foto = foto;
            Prezzo = prezzo;
        }

        public Pizza(int id, string nome, string descrizione, string foto, double prezzo)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
            Foto = foto;
            Prezzo = prezzo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Foto { get; set; }
        public double Prezzo { get; set; }
    }
}