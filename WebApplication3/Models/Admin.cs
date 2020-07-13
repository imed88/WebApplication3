using System;

namespace WebApplication3.Models
{
    public class Admin
    {
        public int idAdmin { get; set; }
        public string nameAdmin { get; set; }
        public string emailAdmin { get; set; }
		public string passwordAdmin { get; set; }
		public string phoneAdmin { get; set; }
        public DateTime created { get; set; }
    }
	
}