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
    public partial class API : ContentPage
    {
        public API()
        {
            InitializeComponent();
            BindingContext = new ApiDataViewModel();

        }
    }
}