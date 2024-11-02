using TP_MVC.Models;

namespace MVC_TP.Services
{
    public class Repositorio
    {
        private List<Cantores> Cantores = new List<Cantores>();

        public Repositorio()
        {
            Cantores.Add(new Cantores { Id = 1, Nome = "Taylor Swift", Estilo = "Pop" });
            Cantores.Add(new Cantores { Id = 2, Nome = "Olivia Rodrigo", Estilo = "Pop/Rock"});
            Cantores.Add(new Cantores { Id = 3, Nome = "Dua Lipa", Estilo = "Pop" });
            Cantores.Add(new Cantores { Id = 4, Nome = "Eminem", Estilo = "Rap" });
        }
        public List<Cantores> GetCantores() { return Cantores; }
        public Cantores? GetCantoresByID(int id) { return Cantores.FirstOrDefault(Cantores => Cantores.Id == id); }
    }
}