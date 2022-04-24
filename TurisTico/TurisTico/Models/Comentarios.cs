using SQLite;

namespace TurisTico.Models
{
    public class Comentarios
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Comentario { get; set; }



    }
}
