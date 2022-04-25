using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurisTico.Models
{

    [Table("tbl_Limon")]

    public class Lugares_Limon
    {

        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Ubicacion { get; set; }


        public string Precio_Lugar { get; set; }

        public string Descripcion_Lugar { get; set; }


        public string Image_Lugar { get; set; }


    }
}
