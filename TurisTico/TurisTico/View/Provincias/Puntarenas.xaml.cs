using System;
using System.Collections.ObjectModel;
using TurisTico.Data;
using TurisTico.Models;
using TurisTico.View.InfoLugar;
using Xamarin.Forms;

namespace TurisTico.View
{
    public partial class Puntarenas : ContentPage
    {


        public ObservableCollection<Lugares_Puntarenas> Datos_Puntarenas { get; set; } = new
            ObservableCollection<Lugares_Puntarenas>();

        public Puntarenas()
        {
            InitializeComponent();



            //aqui se puede llamar el metodo creados en repostirio (get by id )


            DatosRepository repos2 = new DatosRepository();
            foreach (var datos2 in repos2.ListPuntarenas())
            {
                Datos_Puntarenas.Add(datos2);
            }
            BindingContext = this;








        }
        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }
        private async void TapGestureRecognizer_Info_Lugar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Info_Lugar_Puntarenas());
        }
    }





}
