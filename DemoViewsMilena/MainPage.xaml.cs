using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoViewsMilena
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            timzPickInicial.Time = new TimeSpan(17, 0, 0);
        }

        async void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            await DisplayAlert("Completado",
                             "Se ha completado la carga de la pagina",
                             "OK"
                );
        }

    }



}
