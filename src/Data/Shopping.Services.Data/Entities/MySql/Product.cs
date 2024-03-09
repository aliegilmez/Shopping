namespace Shopping.Services.Data.Entities.MySql
{
    public class Product: Atlas.Framework.Data.Mysql.Entity
    {
        public required string Name { get; set; }
    }
}
