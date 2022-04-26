using System;
using System.Collections.ObjectModel;
using TurisTico.Data;
using TurisTico.Models;
using TurisTico.View.InfoLugar;
using Xamarin.Forms;

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

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }
        private async void TapGestureRecognizer_Info_Lugar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info_Lugar_Playas());
        }
    }




}



