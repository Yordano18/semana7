using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using semana7.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;

        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<Database>().GetConnection();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datosRegistro = new Estudiante { Nombre = txtNombre.Text, Usuario = txtUsuario.Text, Contrasena = txtContrasena.Text };
                con.InsertAsync(datosRegistro);
                Navigation.PushAsync(new Login());


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");


            }
        }
        private void DisplayAlert(string v1, object message, string v2)
        {
            throw new NotImplementedException();
        }
    }
}


