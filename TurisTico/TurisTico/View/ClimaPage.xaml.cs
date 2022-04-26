using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TurisTico.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClimaPage : ContentPage
    {
        public ClimaPage()
        {
            InitializeComponent();
            BindingContext = new ClimaViewModel();
            BindingContext = new LimonClimaViewModel();
        }
    }
}