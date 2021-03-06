using Dapper.Contrib.Extensions;

namespace DapabaseLibrary.Model
{
    [Table("Seller")]
    public class Seller
    {
        public Seller()
        {}

        public Seller(int Id, 
            string Login, 
            string Password, 
            string Last_login_time, 
            int Personal_data
        )
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.Last_login_time = Last_login_time;
            this.Personal_data = Personal_data;
        }

        [Key] public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Last_login_time { get; set; }
        public int Personal_data { get; set; }

        // TODO: Implement table data
    }
}