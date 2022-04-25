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

    public partial class Limon : ContentPage
    {


        public ObservableCollection<Lugares_Limon> Datos_Limon { get; set; } = new
           ObservableCollection<Lugares_Limon>();

        DatosRepository repos = new DatosRepository();


        public Limon()
        {
            InitializeComponent();


            foreach (var datos2 in repos.ListLimon())
            {
                Datos_Limon.Add(datos2);
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