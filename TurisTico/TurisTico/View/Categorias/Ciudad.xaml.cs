using System;
using System.Collections.ObjectModel;
using TurisTico.Data;
using TurisTico.Models;
using Xamarin.Forms;

namespace TurisTico.View
{
    public partial class Ciudad : ContentPage
    {


        public ObservableCollection<Lugares_Ciudad> Datos_Ciudad { get; set; } = new
               ObservableCollection<Lugares_Ciudad>();


        public Ciudad()
        {
            InitializeComponent();



            DatosRepository repos2 = new DatosRepository();
            foreach (var datos2 in repos2.List_Ciudad())
            {
                Datos_Ciudad.Add(datos2);
            }
            BindingContext = this;




        }


        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }
        private async void TapGestureRecognizer_Info_Lugar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info_Lugar());
        }

    }
}