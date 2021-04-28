using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora.Vista
{
    public partial class MainPage : ContentPage
    {
        Double N1;
        Double N2;
        Double Resultado;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHola_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnCalculadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimerPagina());
        }

        private async void btncalcular_Clicked(object sender, EventArgs e)
        {
           String operacion= await DisplayActionSheet("Seleccione operación", "cancelar", null, "Sumar", "Restar", "Multiplicar", "Dividir");

            switch (operacion)
            {
                case "Sumar":
                    sumar();
                    break;
                case "Restar":
                    restar();
                    break;
                case "Multiplicar":
                    multiplicar();
                    break;
                case "Dividir":
                    dividir();
                    break;
            }
        }

        private void sumar() {
            if (!String.IsNullOrEmpty(txtnumero1.Text))
            {
                if (!String.IsNullOrEmpty(txtnumero2.Text))
                {
                    N1 = Convert.ToDouble(txtnumero1.Text);
                    N2 = Convert.ToDouble(txtnumero2.Text);
                    Resultado = N1 + N2;
                    DisplayAlert("Resultado", Resultado.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Error", "Ingrese número 2", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese número 1", "OK");
            }
        }

        private void restar()
        {
            if (!String.IsNullOrEmpty(txtnumero1.Text))
            {
                if (!String.IsNullOrEmpty(txtnumero2.Text))
                {
                    N1 = Convert.ToDouble(txtnumero1.Text);
                    N2 = Convert.ToDouble(txtnumero2.Text);
                    Resultado = N1 - N2;
                    DisplayAlert("Resultado", Resultado.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Error", "Ingrese número 2", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese número 1", "OK");
            }
        }

        private void multiplicar()
        {
            if (!String.IsNullOrEmpty(txtnumero1.Text))
            {
                if (!String.IsNullOrEmpty(txtnumero2.Text))
                {
                    N1 = Convert.ToDouble(txtnumero1.Text);
                    N2 = Convert.ToDouble(txtnumero2.Text);
                    Resultado = N1 * N2;
                    DisplayAlert("Resultado", Resultado.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Error", "Ingrese número 2", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese número 1", "OK");
            }
        }

        private void dividir()
        {
            if (!String.IsNullOrEmpty(txtnumero1.Text))
            {
                if (!String.IsNullOrEmpty(txtnumero2.Text))
                {
                    N1 = Convert.ToDouble(txtnumero1.Text);
                    N2 = Convert.ToDouble(txtnumero2.Text);
                    Resultado = N1 / N2;
                    DisplayAlert("Resultado", Resultado.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Error", "Ingrese número 2", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese número 1", "OK");
            }
        }
    }
}
