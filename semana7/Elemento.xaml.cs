using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class Elemento : ContentPage
    {
        public int idSeleccionado;
        private SQLiteAsyncConnection con;
        IEnumerable<Estudiante> Rupdate;
        IEnumerable<Estudiante> Rdelete;

        public Elemento(int id, string nombre, string usuario, string contrasena)
        {
            InitializeComponent();
            idSeleccionado = id;
            con = DependencyService.Get<Database>().GetConnection();
            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;

        }

        public static IEnumerable<Estudiante> Delete(SQLiteConnection db, int id)
        {
            return db.Query<Estudiante>("Delete From Estudiante where id= ?", id);
        }
        public static IEnumerable<Estudiante> Update(SQLiteConnection db, string nombre, string usuario, string contrasena, int id)
        {
            return db.Query<Estudiante>("Update Estudiante set Nombre = ?, Usuario =?, Contrasena=? where id = ?", nombre, usuario, contrasena, id);

        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.db3");
                var db = new SQLiteAsyncConnection(databasePath);
                Rupdate = Update(db, txtNombre.Text, txtUsuario.Text, txtContrasena.Text, idSeleccionado);
                Navigation.PushAsync(new ConsultaRegistro());

            }
            catch (Exception )
            {

                throw;
            }
        }

        private IEnumerable<Estudiante> Update(SQLiteAsyncConnection db, string text1, string text2, string text3, int idSeleccionado)
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.db3");
                var db = new SQLiteAsyncConnection(databasePath);
                Rdelete = Delete(db, idSeleccionado);
                Navigation.PushAsync(new ConsultaRegistro());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private IEnumerable<Estudiante> Delete(SQLiteAsyncConnection db, int idSeleccionado)
        {
            throw new NotImplementedException();
        }
    }
}

