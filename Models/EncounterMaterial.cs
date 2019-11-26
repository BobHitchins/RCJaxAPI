using System;

namespace RCJaxWeb.Models
{
    public class EncounterMaterial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Cost { get; set; }
        public string Link { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
