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
                    Nombre = "Four Seasons Resort",
                    Lugar = "Papagayo",
                    Image = "lugar1.jpg",

                    Precio = 500

                },

                new Product
                {
                    Nombre = "W Costa Rica",
                    Lugar = "Reserva Conchal",
                    Image = "lugar2.jpg",

                    Precio = 200

                },

                new Product
                {
                    Nombre = "Altos de Eros ",
                    Lugar = "Tamarindo",
                    Image = "lugar3.jpg",

                    Precio = 250

                },

                new Product
                {
                    Nombre = "Dreams Las Mareas",
                    Lugar = "Playa El Jobo",
                   Image = "lugar4.jpg",

                    Precio = 234
                },

                new Product
                {
                    Nombre = "Fenix Hotel",
                    Lugar = "Playa Samara",
                    Image = "lugar5.jpg",

                    Precio = 77

                },

               new Product
                {
                    Nombre = "Villa Buena Onda",
                    Lugar = "Playas del Coco",
                    Image = "lugar6.jpg",

                    Precio = 80

                },


               new Product
                {
                    Nombre = "Margaritaville ",
                    Lugar = "Playa Flamingo",
                    Image = "lugar7.jpg",

                    Precio = 120

                },




            };


        }

    }
}
