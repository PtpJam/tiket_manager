using DapabaseLibrary.Model;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DapabaseLibrary.Controller.Database
{
    public class Ticket_Controller
    {
        public Ticket_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Tickets = connection.GetAll<Ticket>() as List<Ticket>;
            connection.Close();
        }
        public void Add(Ticket obj, SqlConnection connection)
        {
            Tickets.Add(obj);
            connection.Insert<Ticket>(obj);
        }

        public Ticket this[int index]
        {
            get => Tickets[index];
            private set => Tickets[index] = value;
        }

        public List<Ticket> Tickets{ get; private set; }
    }
}
