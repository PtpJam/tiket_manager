using DapabaseLibrary.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DapabaseLibrary.Controller.Database
{
    class Staff_Controller
    {
        public Staff_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Staffs = connection.GetAll<Carriage>() as List<Staff>;
            connection.Close();
        }

        public void Add(Staff obj, SqlConnection connection)
        {
            Staffs.Add(obj);
            connection.Insert<Staff>(obj);
        }

        public Staff this[int index]
        {
            get => Staffs[index];
            private set => Staffs[index] = value;
        }

        public List<Staff> Staffs { get; set; }
    }
}
