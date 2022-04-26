using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View.ApiClima
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CLima : ContentPage
    {
        public CLima()
        {
            InitializeComponent();
            BindingContext = new ClimaViewModel();

        }
    }
}