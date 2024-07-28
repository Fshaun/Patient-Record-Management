namespace PatientRecordManagement.Models.Logic_Models
{
    public class AppointmentReminder
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public DateTime ReminderDate { get; set; }
        public bool IsSent { get; set; }
    }

}
