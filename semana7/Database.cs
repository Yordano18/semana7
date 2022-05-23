using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace semana7
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();  //implementado en cada proyecto 


    }
}
