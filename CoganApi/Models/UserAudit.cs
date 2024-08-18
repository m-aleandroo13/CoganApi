using System.ComponentModel.DataAnnotations.Schema;

namespace CoganApi.Models
{
    [Table("useraudit")]
    public class UserAudit
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public string Activity { get; set; }
        public string Module { get; set; }
        public DateTime DateTime { get; set; }

        public UserManagement UserManagement { get; set; }
    }
}
