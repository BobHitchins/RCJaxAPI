using System;

namespace RCJaxWeb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string AltEmail { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsTeamLead { get; set; }
        public bool IsSpiritualDir { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
