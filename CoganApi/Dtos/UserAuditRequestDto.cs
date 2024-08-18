namespace CoganApi.Dtos
{
    public class UserAuditRequestDto
    {
        public string Username { get; set; }
        public string Activity { get; set; }
        public string Module { get; set; }
    }
}
