using DapabaseLibrary.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DapabaseLibrary.Controller.Database
{
    public class Client_Controller
    {
        public Client_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Clients = connection.GetAll<Client>() as List<Client>;
            connection.Close();
        }
        public void Add(Client obj, SqlConnection connection)
        {
            Clients.Add(obj);
            connection.Insert<Client>(obj);
        }

        public Client this[int index]
        {
            get => Clients[index];
            private set => Clients[index] = value;
        }

        public List<Client> Clients{ get; private set; }
    }
}
