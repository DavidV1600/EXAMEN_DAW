namespace Test_Examen.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nume { get; set; }
        public List<Carte> Carti { get; set; }
    }
}