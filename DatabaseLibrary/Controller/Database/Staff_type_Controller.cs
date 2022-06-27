using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using DapabaseLibrary.Model;
using System.Collections.Generic;

namespace DapabaseLibrary.Controller.Database
{
    public class Staff_type_Controller
    {
        public Staff_type_Controller()
        {
            SqlConnection connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            StaffTypes = connection.GetAll<Staff_type>() as List<Staff_type>;
            connection.Close();
        }

        public void Add(Staff_type obj, SqlConnection connection)
        {
            StaffTypes.Add(obj);
            connection.Insert<Staff_type>(obj);
        }

        public Staff_type this[int index]
        {
            get => StaffTypes[index];
            private set => StaffTypes[index] = value;
        }

        public List<Staff_type> StaffTypes { get; private set; }
        
    }
}
