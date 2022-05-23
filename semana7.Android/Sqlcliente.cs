using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using semana7.Droid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[assembly:Xamarin.Forms.Dependency(typeof(Sqlcliente))]// aqui esta el error esperame un 5

namespace semana7.Droid
{
    public class Sqlcliente : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {

            var databasePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(databasePath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);
                   
                      
        }
    }
}