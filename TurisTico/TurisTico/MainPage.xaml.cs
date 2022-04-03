using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurisTico.ViewModels;
using Xamarin.Forms;

namespace TurisTico
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

        }

        public double ColumnSpacing { get; set; }




    }
}
