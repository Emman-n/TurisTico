using SQLite;

namespace TurisTico.Models
{


    [Table("tbl_Playas")]
    public class Lugares_Playas
    {


        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nombre_Lugar { get; set; }

        public string Ubicacion { get; set; }


        public string Precio { get; set; }

        public string Descripcion_Lugar { get; set; }


        public string Image_Lugar { get; set; }


    }
}
