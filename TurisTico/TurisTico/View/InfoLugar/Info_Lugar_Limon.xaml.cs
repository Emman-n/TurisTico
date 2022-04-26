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
    public partial class Info_Lugar_Limon : ContentPage
    {


        public ObservableCollection<Lugares_Limon> Datos_Limon_id { get; set; } = new
          ObservableCollection<Lugares_Limon>();
        DatosRepository repos = new DatosRepository();


        public Info_Lugar_Limon()
        {
            InitializeComponent();

            var getIDpls = repos.ListProductid_Limon(3);
            Datos_Limon_id.Add(getIDpls);
            BindingContext = this;
        }

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }
    }


}