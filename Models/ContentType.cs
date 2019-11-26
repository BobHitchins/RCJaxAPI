using System;

namespace RCJaxWeb.Models
{
    public class ContentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
