using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using people.Models;

namespace people
{
   public class PersonRespositoryCRUD
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        //Constructor de la conexion
        public PersonRespositoryCRUD(string dbPath)
        {
            //Creamos la coneccion
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<person>();
        }
    }
}
