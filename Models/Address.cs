using System;

namespace RCJaxWeb.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateAbbr { get; set; }
        public string Zip { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
