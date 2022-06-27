using Dapper.Contrib.Extensions;

namespace DapabaseLibrary.Model
{

    [Table("Staff")]
    class Staff
    {
        public Staff() { }
        public Staff(
            int Id,
            int Staff_type_id,
            int Passport_id
        )
        {
            this.Id = Id;
            this.Staff_type_id = Staff_type_id;
            this.Passport_id = Passport_id;
        }

        [Key] public int Id { get; set; }
        public int Staff_type_id { get; set; }
        public int Passport_id { get; set; }
    }
}
