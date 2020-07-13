using System;

namespace WebApplication3.Models
{
	public class Doctors
    {
        public int idDoctors { get; set; }
        public string nameDoctors { get; set; }
        public string emailDoctors { get; set; }
		public string passwordDoctors { get; set; }
		public string phoneDoctors { get; set; }
		public int gender { get; set; }
		public string specialist { get; set; }
        public DateTime created { get; set; }
    }
}