using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("NotoSans-Regular.ttf",Alias = "Noto")]
[assembly: ExportFont("DancingScript-Bold.ttf", Alias = "Dancing")]
namespace TurisTico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
