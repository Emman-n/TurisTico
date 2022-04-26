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
    
    
        public class LimonClimaViewModel : INotifyPropertyChanged
        {
            private ClimaData data;

            public ClimaData Data2
            {
                get => data;
                set
                {
                    data = value;
                    OnPropertyChanged();
                }

            }
            public ICommand buscarCommand { get; set; }

            public LimonClimaViewModel()
            {
                buscarCommand = new Command(async () =>
                {
                    //Lon & Lat
                    //var entrada = coordenas as string;
                    //var datos = entrada.Split(',');
                    //var lat = datos[0];
                    //var lon = datos[1];

                    //await GetData("https://api.weatherbit.io/v2.0/current?lat=10.0061&lon=-83.8046&key=9065571412c74430a33f2d24d160572b&lang=es");
                    await GetData("https://api.weatherbit.io/v2.0/current?lat=9.9333&lon=-84.0833&key=9065571412c74430a33f2d24d160572b&lang=es");
                });
            }

            private async Task GetData(String url)
            {
                var cliente = new HttpClient();
                var respuesta = await cliente.GetAsync(url);
                respuesta.EnsureSuccessStatusCode();

                var jsonResult = await respuesta.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ClimaData>(jsonResult);

                Data2 = resultado;
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
