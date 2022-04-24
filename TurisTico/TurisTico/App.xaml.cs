using System.IO;
using System.Reflection;
using TurisTico.Data;
using Xamarin.Forms;


[assembly: ExportFont("NotoSans-Regular.ttf", Alias = "Noto")]
[assembly: ExportFont("DancingScript-Bold.ttf", Alias = "Dancing")]
namespace TurisTico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();




            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            using (Stream stream =
                assembly.GetManifestResourceStream("TurisTico.Datos.db"))
            {

                using (MemoryStream memoryStream = new MemoryStream())
                {

                    stream.CopyTo(memoryStream);

                    File.WriteAllBytes(DatosRepository.DbPath, memoryStream.ToArray());

                }



            }







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
