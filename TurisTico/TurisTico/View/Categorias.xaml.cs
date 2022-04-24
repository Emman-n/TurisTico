using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categorias : ContentPage
    {
        public Categorias()
        {
            InitializeComponent();

        }

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }


        //Conexion a lista de lugares
        private async void btnSanJose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SanJose());


        }

        private async void btnPlayas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Playas());

        }

        private async void btnMotanas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Montana());

        }

        private async void btnCiudad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ciudad());

        }

        private async void btnBosques_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bosque());

        }
    }
}