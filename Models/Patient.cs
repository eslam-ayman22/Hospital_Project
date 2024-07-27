namespace Hospital.Models
{
    public class Patient
    {
       
            public int Id { get; set; }
            public string PatientName { get; set; }
            public DateOnly AppointmentDate { get; set; }
            public TimeOnly AppointmentTime { get; set; }
            public string? DoctorName { get; set; }
      
    }
}
