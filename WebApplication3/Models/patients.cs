using System;

namespace WebApplication3.Models
{
	public class Patients
    {
        public int idPatients { get; set; }
        public string namePatients { get; set; }
     	public string phonePatients { get; set; }
		public int gender { get; set; }
		public string health_condition { get; set; }
		public int doctor_id { get; set; }
		public int nurse_id { get; set; }
		public DateTime created { get; set; }
    }
}