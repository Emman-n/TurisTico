using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurisTico.Models
{



    [Table("tbl_Puntarenas")]
    public class Lugares_Puntarenas
    {


        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Ubicacion { get; set; }


        public decimal Precio_Lugar { get; set; }

        public string Descripcion_Lugar { get; set; }


        public string Image_Lugar { get; set; }


    }
}
