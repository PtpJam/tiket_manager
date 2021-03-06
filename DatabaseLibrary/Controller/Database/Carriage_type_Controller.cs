using DapabaseLibrary.Model;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DapabaseLibrary.Controller.Database
{
    public class Carriage_type_Controller
    {
        public Carriage_type_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Carriage_types = connection.GetAll<Carriage_type>() as List<Carriage_type>;
            connection.Close();
        }
        public void Add(Carriage_type obj, SqlConnection connection)
        {
            Carriage_types.Add(obj);
            connection.Insert<Carriage_type>(obj);
        }

        public Carriage_type this[int index]
        {
            get => Carriage_types[index];
            private set => Carriage_types[index] = value;
        }

        public List<Carriage_type> Carriage_types{ get; private set;}
    }
}
