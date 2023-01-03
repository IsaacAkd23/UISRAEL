using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UISRAEL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnCalcularP1_Clicked(object sender, EventArgs e)
        {
            double nSeguimiento = Convert.ToDouble(txtNSeguimiento.Text);               
            double nExamen = Convert.ToDouble(txtNExamen.Text);

            double parcial1 = (nSeguimiento * 0.3) + (nExamen * 0.2);
            txtResultadoP1.Text = parcial1.ToString();
        }

        private void btnCalcularP2_Clicked(object sender, EventArgs e)
        {
            double nSeguimiento2 = Convert.ToDouble(txtNSeguimiento2.Text);
            double nExamen2 = Convert.ToDouble(txtNExamen2.Text);

            double parcial2 = (nSeguimiento2 * 0.3) + (nExamen2 * 0.2);
            txtResultadoP2.Text = parcial2.ToString();
        }

        private void btnCalcularNF_Clicked(object sender, EventArgs e)
        {
            double resultadop1 = Convert.ToDouble(txtResultadoP1.Text);
            double resultadop2 = Convert.ToDouble(txtResultadoP2.Text);

            double notafinal = resultadop1 + resultadop2;
            txtNotaFinal.Text = notafinal.ToString();

            double notafinalif = Convert.ToDouble(txtNotaFinal.Text);

            if (notafinalif < 5)

            {
                DisplayAlert("ESTADO", "REPROBADO", "Cerrar");
            }

            if (notafinalif <= 7)

            {
                return;
            }
            DisplayAlert("ESTADO", "APROBADO", "Cerrar");

        }
    }
}