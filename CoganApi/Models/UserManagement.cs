using System.ComponentModel.DataAnnotations.Schema;

namespace CoganApi.Models
{
    [Table("users")]
    public class UserManagement
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Job_Title { get; set; }
        public string User_Level { get; set; }
        public string Status { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public string Last_Updated_By { get; set; }


        public ICollection<UserAudit> UserAudits { get; set; }
    }
}
