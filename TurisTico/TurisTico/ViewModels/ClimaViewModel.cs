using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TurisTico.Models;
using Xamarin.Forms;

namespace TurisTico.ViewModels
{
    public class ClimaViewModel : INotifyPropertyChanged
    {
        private ApiData apidata;
        public ApiData Data
        {
            get => apidata;
            set
            {
                apidata = value;
                OnPropertyChanged();
            }

        }

        public ICommand buscarCommand { get; set; }


        public ClimaViewModel()
        {
            buscarCommand = new Command(async () =>
            {


                await GetData("https://api.openweathermap.org/data/2.5/weather?q=Alajuela&appid=8b1d98316f6c5c57e1e8cc898dc5a8d9");
            });
        }
        private async Task GetData(String url)
        {
            var objetoanonimo = new ApiData();
            var cliente = new HttpClient();
            var respuesta = await cliente.GetAsync(url);
            respuesta.EnsureSuccessStatusCode();

            var jsonResult = await respuesta.Content.ReadAsStringAsync();
            //var resultado = JsonConvert.DeserializeObject<ApiData>(jsonResult);
            //var resultado = JsonConvert.DeserializeAnonymousType(jsonResult, objetoanonimo.rootobject);


            var resultado = JsonConvert.DeserializeObject<ApiData>(jsonResult);


            Data = resultado;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
