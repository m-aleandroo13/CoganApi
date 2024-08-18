namespace CoganApi.Dtos
{
    public class UserManagementDto
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string JobTitle { get; set; }
        public string UserLevel { get; set; }
        public string Status { get; set; } = "active";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
