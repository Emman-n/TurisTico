﻿using SQLite;

namespace TurisTico.Models
{


    [Table("Alajuela")]
    public class Lugares_Alajuela
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
