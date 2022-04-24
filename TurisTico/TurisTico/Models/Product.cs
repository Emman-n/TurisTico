using SQLite;

namespace TurisTico.Models
{


    [Table("tbl_datos")]
    public class Product
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Lugar { get; set; }


        public decimal Precio { get; set; }

        public byte Imagen { get; set; }
    }


}