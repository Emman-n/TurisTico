using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.Models;
using TurisTico.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public IList<Provincias> provinciasss { get; private set; }
        public Inicio()
        {
            InitializeComponent();
            provinciasss = new List<Provincias>();


            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "Guanacaste",
                descripcion = "La cuna de nuestro folklore.La belleza incomparable de sus paisajes que van desde el bosque seco tropical hasta el bosque montano bajo y su cálido clima, así como su fértil naturaleza han hecho de Guanacaste uno de los lugares más concurridos por el turismo local e internacional y es una de las regiones de mayor desarrollo",
                Imagen_url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0c/76/8a/9d/catarata-rio-celeste.jpg?w=1000&h=-1&s=1"

            });

            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "Puntarenas",
                descripcion = "Te garantizamos rotundamente que el disfrute en esta región es algo que no se debe poner en duda, atrévete a conocer.",
                Imagen_url = "https://passporterapp.com/es/blog/wp-content/uploads/2021/11/Puntarenas-Costa-Rica.jpg"


            });


            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "Alajuela",
                descripcion = "El turismo en Alajuela se expande a muchas otras áreas. No son solo atracciones en la naturaleza o a las que necesitas ir con una compañía de tours, también son lugares turísticos que tú puedes visitar solo o acompañado de parejas, familiares y amigos.",
                Imagen_url = "https://www.riojarentacar.com/wp-content/uploads/2009/10/Alajuela-Costa-Rica-1024x1024.jpg"

            });
            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "Limón",
                descripcion = "Limón es un lugar con un gran atractivo turístico, al igual que el resto de Costa Rica, puesto que se encuentra situado en este maravilloso país ideal para hacer turismo y explorar nuevas formas de vida.",
                Imagen_url = "https://viajareacostarica.com/wp-content/uploads/2020/08/limon-1000x669.jpg"

            });
            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "San José",
                descripcion = "San José es una de las localidades más trascendentales de América Latina. Por esta razón, hay numerosas cosas culturales e históricas para hacer en San José, Costa Rica. Todo lo que necesitas es un día o dos para descubrir las joyas de San José",
                Imagen_url = "https://strawberrytours.com/images/LandingPages/SanJose/San-Jose-1000x667.jpg"

            });
       
            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "Heredia",
                descripcion = "En la provincia de Heredia podrás descubrir y explorar los increíbles parques naturales.Además, te adentrarás en la sorprendente historia de esta zona norte del país conociendo sus lugares más históricos. ",
                Imagen_url = "https://blogapi.uber.com/wp-content/uploads/2019/02/6-hermosos-lugares-para-visitar-en-Heredia-y-enamorarte-de-la-ciudad-1024x512.png"

            });
            provinciasss.Add(new Provincias
            {
                Nommbre_Provincia = "Cartago",
                descripcion = "La belleza que esconde Cartago en sus rincones le ha convertido en un destino favorito para los que buscan un paseo de un día sin gastar mucho dinero. ",
                Imagen_url = "https://www.muni-carta.go.cr/wp-content/uploads/2017/11/lankester-.jpg"


            });
           
            BindingContext = this;  
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Provincias selectedItem = e.SelectedItem as Provincias;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Provincias tappedItem = e.Item as Provincias;

        }
        private async void btnSanJose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SanJose());
            BindingContext = new LugaresViewModel();

        }

        private async void btnPuntarenas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puntarenas());
            BindingContext = new LugaresViewModel();
        }
    }
}