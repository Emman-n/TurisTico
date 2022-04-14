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
                    Nombre = "Nombre = Four Seasons",
                    Lugar = "Ubicacion = Papagayo",
                    Image = "lugar1.jpg",
                     
                    Precio = "Precio = 500"

                },

                new Product
                {
                    Nombre = "W Costa Rica",
                    Lugar = "Reserva Conchal",
                    Image = "lugar2.jpg",

                    Precio = "Precio =200"

                },

                new Product
                {
                    Nombre = "Altos de Eros ",
                    Lugar = "Tamarindo",
                    Image = "lugar3.jpg",

                    Precio = "Precio = 250"

                },

                new Product
                {
                    Nombre = "Dreams Las Mareas",
                    Lugar = "Playa El Jobo",
                   Image = "lugar4.jpg",

                    Precio = "Precio = 234"
                },

                new Product
                {
                    Nombre = "Fenix Hotel",
                    Lugar = "Playa Samara",
                    Image = "lugar5.jpg",

                    Precio = "Precio =77"

                },

               new Product
                {
                    Nombre = "Villa Buena Onda",
                    Lugar = "Playas del Coco",
                    Image = "lugar6.jpg",

                    Precio = "Precio =80 "

                },


               new Product
                {
                    Nombre = "Margaritaville ",
                    Lugar = "Playa Flamingo",
                    Image = "lugar7.jpg",

                    Precio = "Precio =120"

                },




            };


        }

    }
}
