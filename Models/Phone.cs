using System;

namespace RCJaxWeb.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
