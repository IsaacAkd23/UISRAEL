using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UISRAEL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "irivera";
            string contraseña = "12345";

            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Principal(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña Incorrecta", "Cerrar");
            }
        }
    }
}