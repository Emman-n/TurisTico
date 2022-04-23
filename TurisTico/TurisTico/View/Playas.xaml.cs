using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.Data;
using TurisTico.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{



    public partial class Playas : ContentPage
    {


        public ObservableCollection<Lugares_Playas> Datos_Playas { get; set; } = new
                ObservableCollection<Lugares_Playas>();



        public Playas()
        {
            InitializeComponent();

            DatosRepository repos2 = new DatosRepository();
            foreach (var datos2 in repos2.ListPlayas())
            {
                Datos_Playas.Add(datos2);
            }
            BindingContext = this;








        }





    }





}
