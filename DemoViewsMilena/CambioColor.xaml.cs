using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoViewsMilena
{
    public partial class CambioColor : ContentPage
    {
        public CambioColor()
        {
            InitializeComponent();
        }
        void CambiarColor(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var rojo = slrojo.Value;
            var azul = slazul.Value;
            var verde = slverde.Value;
            Color bgcolor = new Color(rojo, verde, azul);
            boxcolor.BackgroundColor = bgcolor;
            lbDisplay.Text = ColorToHex(bgcolor);
        }
        private string ColorToHex(Color color){
            int rojo = (int)(color.R * 255);
            int verde = (int)(color.G * 255);
            int azul = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            return $"#{rojo:X2}{verde:X2}{azul:X2}{alpha:X2}";
        }

    }
}