using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TurisTico.Models;
using Xamarin.Forms;
using static TurisTico.Models.ApiData;

namespace TurisTico.ViewModels
{

    public class ApiDataViewModel : INotifyPropertyChanged
    {

        private ApiData data;




        public ApiData Data
        {
            get => data;
            set
            {
                data = value;
                OnPropertyChanged();
            }

        }
        public ICommand buscarCommand { get; set; }

        public ApiDataViewModel()
        {
            buscarCommand = new Command(async () =>
            {
                await GetData("https://api.openweathermap.org/data/2.5/weather?q=Alajuela&appid=8b1d98316f6c5c57e1e8cc898dc5a8d9");
            });
        }

        private async Task GetData(String url)
        {
            var cliente = new HttpClient();
            var respuesta = await cliente.GetAsync(url);
            respuesta.EnsureSuccessStatusCode();

            var jsonResult = await respuesta.Content.ReadAsStringAsync();
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



//private ApiData data;

//public ApiData Data
//{

//    get => data;

//    set
//    {

//        data = value;
//        OnPropertyChanged();
//    }
//}



//public ICommand buscarCommand { get; set; }


//public ApiViewModel()
//{

//    buscarCommand = new Command(async (coordenas) =>
//    {
//        //Lon & Lat


//        await GetData($"http://dataservice.accuweather.com/locations/v1/cities/search?apikey=iFRAN9vSgKGefADJb0AhTVfUshIMoqcK&q=Alajuela%20");
//    });
//}

//private async Task GetData(String url)
//{
//    var cliente = new HttpClient();
//    var respuesta = await cliente.GetAsync(url);
//    respuesta.EnsureSuccessStatusCode();

//    var jsonResult = await respuesta.Content.ReadAsStringAsync();
//    var resultado = JsonConvert.DeserializeObject<ApiData>(jsonResult);

//    Data = resultado;
//}

//public event PropertyChangedEventHandler PropertyChanged;

//private void OnPropertyChanged([CallerMemberName] string propertyName = null)
//{
//    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//}

