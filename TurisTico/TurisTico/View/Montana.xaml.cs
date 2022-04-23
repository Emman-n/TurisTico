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

namespace TurisTico.View
{
    public partial class Montana : ContentPage
    {



        public ObservableCollection<Lugares_Montanas> Datos_Motanas { get; set; } = new
                ObservableCollection<Lugares_Montanas>();


        public Montana()
        {
            InitializeComponent();
            DatosRepository repos2 = new DatosRepository();
            foreach (var datos2 in repos2.ListMnotanas())
            {
                Datos_Motanas.Add(datos2);
            }
            BindingContext = this;








        }





    }





}
