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
        public void CreatePerson(person newPerson)
        {
            int result;
            result = conn.Insert(newPerson);
            if (result == 1)
            {
                StatusMessage = $"{result} Registros agregados [Nombre: " + $"{newPerson.Name}, ID {newPerson.Id}]";
            }
            else
            {
                StatusMessage = "Registros no insertados";
            }

        }

        public List<person> GetAllPeople()
        {
            return conn.Table<person>().ToList();
        }
    }
}
