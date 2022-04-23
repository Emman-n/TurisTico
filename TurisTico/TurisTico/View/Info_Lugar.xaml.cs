using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Info_Lugar : ContentPage
    {
        public Info_Lugar()
        {
            InitializeComponent();
        }


        private async void ToolbarItem_Clicked_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

    }
}