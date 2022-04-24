using SQLite;

namespace TurisTico.Models
{
    [Table("tbl_Montañas")]


    public class Lugares_Montanas
    {

        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Ubicacion { get; set; }


        public int Precio_Lugar { get; set; }

        public string Descripcion_Lugar { get; set; }


        public string Image_Lugar { get; set; }


    }
}
