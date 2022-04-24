
using System.Collections.ObjectModel;

using TurisTico.Data;
using TurisTico.Models;
using Xamarin.Forms;


namespace TurisTico
{

    public partial class SanJose : ContentPage
    {

        public ObservableCollection<Product> Products_ID { get; set; } = new
            ObservableCollection<Product>();
        public SanJose()
        {
            InitializeComponent();



            //aqui se puede llamar el metodo creados en repostirio (get by id )


            DatosRepository repos = new DatosRepository();
            var getIDpls = repos.ListProductid(1);
            Products_ID.Add(getIDpls);
            BindingContext = this;




        }


    }
}