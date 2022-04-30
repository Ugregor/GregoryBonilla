using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GregoryBonilla
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnSesion_Clicked(object sender, EventArgs e)
        {
            string usu = txtUsu.Text;
            string pass = txtPass.Text;

            if(usu == "GregoryBonilla" && pass == "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(usu));
            }
            else if (string.IsNullOrEmpty(usu) && string.IsNullOrEmpty(pass))
            {
                await DisplayAlert("Alerta", "Complete los campos", "Cerrar");
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario o Contraseña Incorrecto", "Cerrar");
            }
        }
    }
}