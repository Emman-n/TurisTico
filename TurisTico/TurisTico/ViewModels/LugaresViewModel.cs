using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TurisTico.Models;

namespace TurisTico.ViewModels
{
    
   public class LugaresViewModel
    {

        public ObservableCollection<Product> Products { get; set; }


        public LugaresViewModel()
        {
            Products = new ObservableCollection<Product>()
            {


                new Product
                {
                    Nombre = "Nombre largo 1234568910",
                    Lugar = "lugar",
                    Image = "montanas.jpg",

                    Precio = 111

                },

                new Product
                {
                    Nombre = "a",
                    Lugar = "b",
                    Image = "montanas.jpg",

                    Precio = 111

                },

                   new Product
                {
                    Nombre = "a",
                    Lugar = "b",
                    Image = "montanas.jpg",

                    Precio = 111

                },

                      new Product
                {
                    Nombre = "a",
                    Lugar = "b",
                    Image = "montanas.jpg",

                    Precio = 111

                },

                         new Product
                {
                    Nombre = "a",
                    Lugar = "b",
                    Image = "montanas.jpg",

                    Precio = 111

                },

                                     new Product
                {
                    Nombre = "a",
                    Lugar = "b",
                    Image = "montanas.jpg",

                    Precio = 111

                },


                                                 new Product
                {
                    Nombre = "a",
                    Lugar = "b",
                    Image = "montanas.jpg",

                    Precio = 111

                },




            };
        }

    }
}
