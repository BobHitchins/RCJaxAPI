using System;

namespace RCJaxWeb.Models
{
    public class Content
    {
        public int Id { get; set; }
        public int ContentTypeId { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
