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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string vCuota, string vFinal)
        {
            InitializeComponent();
            txtNom.Text = nombre;
            txtCuota.Text = vCuota;
            txtTotal.Text = vFinal;

        }
    }
}