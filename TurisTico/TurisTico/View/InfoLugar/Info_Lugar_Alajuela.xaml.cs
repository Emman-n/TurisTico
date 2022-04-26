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

namespace TurisTico.View.InfoLugar
{
    public partial class Info_Lugar_Alajuela : ContentPage
    {

        public ObservableCollection<Lugares_Alajuela> Datos_Alajuela_id { get; set; } = new
          ObservableCollection<Lugares_Alajuela>();
        DatosRepository repos = new DatosRepository();


        public Info_Lugar_Alajuela()
        {
            InitializeComponent();


            //aqui se selecciona el lugar :\ 
            var getIDpls = repos.ListProductid_Alajuela(5);
            Datos_Alajuela_id.Add(getIDpls);
            BindingContext = this;
        }

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

    }
}