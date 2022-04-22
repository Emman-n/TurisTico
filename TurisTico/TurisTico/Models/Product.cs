using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

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

        public string Imagen { get; set; }
    }


}