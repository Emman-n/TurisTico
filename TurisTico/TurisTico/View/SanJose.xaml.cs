using System;

using System.Collections.ObjectModel;
using System.IO;

using System.Reflection;

using TurisTico.Data;
using TurisTico.Models;
using Xamarin.Forms;


namespace TurisTico
{

    public partial class SanJose : ContentPage
    {

        public ObservableCollection<Product> Products { get; set; } = new
            ObservableCollection<Product>();
        public SanJose()
        {
            InitializeComponent();



            //aqui se puede llamar el metodo creados en repostirio (get by id )


            DatosRepository repos = new DatosRepository();
            foreach (var datos in repos.ListProduct())
            {
                Products.Add(datos);
            }
            BindingContext = this;






        }
    }
}