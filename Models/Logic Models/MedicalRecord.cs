﻿namespace PatientRecordManagement.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int  DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public string? Notes { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }

}
