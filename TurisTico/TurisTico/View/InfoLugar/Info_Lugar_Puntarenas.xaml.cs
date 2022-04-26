﻿using System;
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
    public partial class Info_Lugar_Puntarenas : ContentPage
    {
        public ObservableCollection<Lugares_Puntarenas> Datos_Puntarenas_id { get; set; } = new
          ObservableCollection<Lugares_Puntarenas>();
        DatosRepository repos = new DatosRepository();




        public Info_Lugar_Puntarenas()
        {
            InitializeComponent();

            var getIDpls = repos.ListProductid_Puntarenas(3);
            Datos_Puntarenas_id.Add(getIDpls);
            BindingContext = this;

        }

        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

    }
}