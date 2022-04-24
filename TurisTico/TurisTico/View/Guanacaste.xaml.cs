using System;
using System.Collections.ObjectModel;
using TurisTico.Data;
using TurisTico.Models;
using Xamarin.Forms;

namespace TurisTico.View
{
    public partial class Guanacaste : ContentPage
    {
        public ObservableCollection<Lugares_Guanacaste> Datos_Gunacaste { get; set; } = new
            ObservableCollection<Lugares_Guanacaste>();

        DatosRepository repos = new DatosRepository();


        public Guanacaste()
        {
            InitializeComponent();

            foreach (var datos2 in repos.ListGuanacaste())
            {
                Datos_Gunacaste.Add(datos2);
            }
            BindingContext = this;

        }

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());


        }
        private async void TapGestureRecognizer_Info_Lugar(object sender, EventArgs e)
        {


            var getIDpls = repos.ListProductid_Guanacaste(1);
            Datos_Gunacaste.Add(getIDpls);
            BindingContext = this;

            await Navigation.PushAsync(new Info_Lugar());


        }
    }


}

