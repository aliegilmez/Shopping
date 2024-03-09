namespace Shopping.Services.Data.Entities.MySql
{
    public class Customer: Atlas.Framework.Data.Mysql.Entity
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
    }
}
