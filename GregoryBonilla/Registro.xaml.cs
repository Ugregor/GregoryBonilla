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
    public partial class Registro : ContentPage
    {
        public Registro(string usu)
        {
            InitializeComponent();
            lblusu.Text = usu;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double total = 3000;
            double cuota = Convert.ToDouble(txtCuota.Text);
            if (cuota > total)
            {
                DisplayAlert("Aleta", "La cuota inicial es mayor que el valor del curso", "Cerrar");
            }
            else
            {
                double v1 = (total - cuota) / 5;
                double vCuota = (v1 * 0.05)+ v1;
                double vFinal = vCuota * 5;
                txtPagos.Text = vCuota.ToString();
                txtTotal.Text = vFinal.ToString();
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNom.Text;
            string vCuota = txtPagos.Text;
            string vFinal = txtTotal.Text;
            await Navigation.PushAsync(new Resumen(nombre, vCuota, vFinal));
        }

    }
}