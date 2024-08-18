namespace CoganApi.Dtos
{
    public class UserAuditResponseDto
    {
        public string Username { get; set; }
        public DateTime ActionTime { get; set; }
        public string Description { get; set; }
    }
}
