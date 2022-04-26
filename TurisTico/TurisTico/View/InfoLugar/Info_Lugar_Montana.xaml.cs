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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Info_Lugar_Montana : ContentPage
    {

        public ObservableCollection<Lugares_Montanas> Datos_Montanas_id { get; set; } = new
        ObservableCollection<Lugares_Montanas>();
        DatosRepository repos = new DatosRepository();



        public Info_Lugar_Montana()
        {
            InitializeComponent();

            //aqui se selecciona el lugar :\ 
            var getIDpls = repos.ListProductid_Montanas(2);
            Datos_Montanas_id.Add(getIDpls);
            BindingContext = this;


        }


        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

    }
}