using System;

namespace RCJaxWeb.Models
{
    public class Afire
    {
        public int Id { get; set; }
        public int AfireTypeId { get; set; }
        public int UserId { get; set; }
        public DateTime DateStarted { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}