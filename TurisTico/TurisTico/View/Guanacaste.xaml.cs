using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.View;
using TurisTico.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SanJose : ContentPage
    {
        public SanJose()
        {
            InitializeComponent();
            BindingContext = new LugaresViewModel();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());

        }
    }
}