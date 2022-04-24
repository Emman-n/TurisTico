using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TurisTico.Data;
using TurisTico.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{
    public partial class Info_Lugar : ContentPage
    {

        public ObservableCollection<Lugares_Guanacaste> Datos_Gunacaste_id { get; set; } = new
           ObservableCollection<Lugares_Guanacaste>();
        DatosRepository repos = new DatosRepository();

        int idfront;


        public Info_Lugar()
        {
            InitializeComponent();



            var getIDpls = repos.ListProductid_Guanacaste(idfront);
            Datos_Gunacaste_id.Add(getIDpls);
            BindingContext = this;

        }


        ////private IEnumerable<string> imageList;

        //public IEnumerable<string> ImageList
        //{


        //    get => imageList;
        //    set => SetProperty(ref imageList, value);
        //}


        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }


        public int getID(int id)
        {

            idfront = id;
            return id;

        }


    }
}