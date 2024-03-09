namespace Shopping.Services.Library.Dto.CommonModels
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
