namespace Test_Examen.Models
{
    public class Carte
    {
        public int CarteId { get; set; }
        public string Titlu { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int EdituraId { get; set; }
        public Editura Editura { get; set; }
    }
}