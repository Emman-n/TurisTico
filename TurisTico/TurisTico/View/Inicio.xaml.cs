using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.Models;
using TurisTico.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{
    public partial class Inicio : ContentPage
    {
        public IList<Provincias> provinciasss { get; private set; }
        public Inicio()
        {
            InitializeComponent();
            provinciasss = new List<Provincias>();


        }


        private async void btnSanJose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SanJose());

        }

        private async void btnPuntarenas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puntarenas());

        }

        private async void btnGuanacaste_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Guanacaste());

        }

        private async void btnCategoria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categorias());

        }

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

        private async void btnAlajuela_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Alajuela());

        }
    }
}